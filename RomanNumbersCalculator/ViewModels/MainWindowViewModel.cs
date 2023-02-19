using System;
using System.Collections.Generic;
using System.Reactive;
using System.Text;
using ReactiveUI;
using RomanNumbersCalculator;
using RomanNumbersCalculator.Models;

namespace RomanNumbersCalculator.ViewModels
{
    public class MainWindowViewModel : ViewModelBase
    {
        private string currentOperationStringRepresentation = "";
        private string currentNumberStringRepresentation = "";
        private Stack<RomanNumberExtend> stackRomanNumbers = new Stack<RomanNumberExtend>();

    
    public string CurrentNumberStringRepresentation
    {
        get => currentNumberStringRepresentation;
        set
        {
            this.RaiseAndSetIfChanged(ref currentNumberStringRepresentation, value);
        }
    }
   
    public ReactiveCommand<string, Unit> AddNumber { get; }
    public ReactiveCommand<Unit, Unit> PlusCommand { get; }
    public ReactiveCommand<Unit, Unit> SubCommand { get; }
    public ReactiveCommand<Unit, Unit> MulCommand { get; }
    public ReactiveCommand<Unit, Unit> DivCommand { get; }
    public ReactiveCommand<Unit, Unit> CalculateCommand { get; }
    public ReactiveCommand<Unit, Unit> ResetCommand { get; }
        public MainWindowViewModel()
        {
            AddNumber = ReactiveCommand.Create<string>(str =>
            {
                if (currentNumberStringRepresentation == "#ERROR") return;
                if (currentOperationStringRepresentation == "=") clear();
                CurrentNumberStringRepresentation += str;
            });
            ResetCommand = ReactiveCommand.Create(() => clear());
            PlusCommand = ReactiveCommand.Create(() => calcNumbOperation("+"));
            SubCommand = ReactiveCommand.Create(() => calcNumbOperation("-"));
            MulCommand = ReactiveCommand.Create(() => calcNumbOperation("*"));
            DivCommand = ReactiveCommand.Create(() => calcNumbOperation("/"));
            CalculateCommand = ReactiveCommand.Create(() =>
            {
                if (stackRomanNumbers.Count != 1
                    || currentNumberStringRepresentation == ""
                    || currentNumberStringRepresentation == "#ERROR")
                {
                    return;
                }

                try
                {
                    RomanNumberExtend newNumber = new(currentNumberStringRepresentation);

                    switch (currentOperationStringRepresentation)
                    {
                        case "+":
                            stackRomanNumbers.Push(stackRomanNumbers.Pop() + newNumber);
                            break;
                        case "-":
                            stackRomanNumbers.Push(stackRomanNumbers.Pop() - newNumber);
                            break;
                        case "*":
                            stackRomanNumbers.Push(stackRomanNumbers.Pop() * newNumber);
                            break;
                        case "/":
                            stackRomanNumbers.Push(stackRomanNumbers.Pop() / newNumber);
                            break;
                        default:
                            break;
                    }
                    currentOperationStringRepresentation = "=";
                    CurrentNumberStringRepresentation = stackRomanNumbers.Peek().ToString();
                }
                catch (RomanNumberException exception)
                {
                    CurrentNumberStringRepresentation = exception.Message;
                }
            });
        }




            private void clear()
            {
            CurrentNumberStringRepresentation = "";
            currentOperationStringRepresentation = "";
            stackRomanNumbers.Clear();
            }

        private void recalculateCurrentNumber(RomanNumberExtend number)
        {
            switch (currentOperationStringRepresentation)
            {
                case "+":
                    stackRomanNumbers.Push(stackRomanNumbers.Pop() + number);
                    break;
                case "-":
                    stackRomanNumbers.Push(stackRomanNumbers.Pop() - number);
                    break;
                case "*":
                    stackRomanNumbers.Push(stackRomanNumbers.Pop() * number);
                    break;
                case "/":
                    stackRomanNumbers.Push(stackRomanNumbers.Pop() / number);
                    break;
            }
        }
        private bool IsCalculationRequired(string operationSymbol)
        {
            if (currentNumberStringRepresentation == "#ERROR")
            {
                return false;
            }

            if (currentNumberStringRepresentation == "")
            {
                if (currentOperationStringRepresentation != "") currentOperationStringRepresentation = operationSymbol;
                return false;
            }

            if (currentOperationStringRepresentation == "=")
            {
                currentOperationStringRepresentation = operationSymbol;
                CurrentNumberStringRepresentation = "";
                return false;
            }

            return true;
        }

        private void calcNumbOperation(string operationSymbol)
        {
            if (!IsCalculationRequired(operationSymbol)) return;

            try
            {
                if (currentOperationStringRepresentation == "")
                {
                    currentOperationStringRepresentation = operationSymbol;
                    RomanNumberExtend newNumber = new RomanNumberExtend(currentNumberStringRepresentation);
                    stackRomanNumbers.Push(newNumber);
                    CurrentNumberStringRepresentation = "";
                }
                else
                {
                    RomanNumberExtend newNumber = new RomanNumberExtend(currentNumberStringRepresentation);
                    recalculateCurrentNumber(newNumber);
                    currentOperationStringRepresentation = operationSymbol;
                    CurrentNumberStringRepresentation = "";

                }
            }
            catch (RomanNumberException exception)
            {
                CurrentNumberStringRepresentation = exception.Message;
            }
        }
    }
}
