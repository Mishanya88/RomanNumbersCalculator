using Avalonia.Controls;
using Avalonia.VisualTree;

namespace UITestsForRomanNumbersCalculator
{
    public class UnitTests
    {
        [Fact]
        public async void TestADD()
        {
            var app = AvaloniaApp.GetApp();
            var mainWindow = AvaloniaApp.GetMainWindow();

            await Task.Delay(100);

            var buttonI = mainWindow.GetVisualDescendants().OfType<Button>().First(b => b.Name == "buttonI");
            var buttonV = mainWindow.GetVisualDescendants().OfType<Button>().First(b => b.Name == "buttonV");
            var buttonX = mainWindow.GetVisualDescendants().OfType<Button>().First(b => b.Name == "buttonX");
            var buttonL = mainWindow.GetVisualDescendants().OfType<Button>().First(b => b.Name == "buttonL");
            var buttonResult = mainWindow.GetVisualDescendants().OfType<Button>().First(b => b.Name == "buttonResult");
            var buttonPls = mainWindow.GetVisualDescendants().OfType<Button>().First(b => b.Name == "buttonPlus");
            var buttonCE = mainWindow.GetVisualDescendants().OfType<Button>().First(b => b.Name == "buttonCE");
            var result = mainWindow.GetVisualDescendants().OfType<TextBlock>().First(textBox => textBox.Name == "ResultText");
            buttonI.Command.Execute(buttonI.CommandParameter);
            buttonPls.Command.Execute(buttonPls.CommandParameter);
            buttonV.Command.Execute(buttonV.CommandParameter);
            buttonResult.Command.Execute(buttonResult.CommandParameter);
            
            await Task.Delay(50);
            string text = result.Text;
            buttonCE.Command.Execute(buttonCE.CommandParameter);
            Assert.True(text == "VI","!VI");

            buttonX.Command.Execute(buttonX.CommandParameter);
            buttonPls.Command.Execute(buttonPls.CommandParameter);
            buttonL.Command.Execute(buttonL.CommandParameter);
            buttonResult.Command.Execute(buttonResult.CommandParameter);

            await Task.Delay(50);
            text = result.Text;
            buttonCE.Command.Execute(buttonCE.CommandParameter);
            Assert.True(text == "LX", "!LX");
            
        }


        [Fact]
        public async void TestSUB()
        {
            var app = AvaloniaApp.GetApp();
            var mainWindow = AvaloniaApp.GetMainWindow();

            await Task.Delay(100);

            var buttonC = mainWindow.GetVisualDescendants().OfType<Button>().First(b => b.Name == "buttonC");
            var buttonV = mainWindow.GetVisualDescendants().OfType<Button>().First(b => b.Name == "buttonV");
            var buttonX = mainWindow.GetVisualDescendants().OfType<Button>().First(b => b.Name == "buttonX");
            var buttonL = mainWindow.GetVisualDescendants().OfType<Button>().First(b => b.Name == "buttonL");
            var buttonResult = mainWindow.GetVisualDescendants().OfType<Button>().First(b => b.Name == "buttonResult");
            var buttonSub = mainWindow.GetVisualDescendants().OfType<Button>().First(b => b.Name == "buttonSub");
            var buttonCE = mainWindow.GetVisualDescendants().OfType<Button>().First(b => b.Name == "buttonCE");
            var result = mainWindow.GetVisualDescendants().OfType<TextBlock>().First(textBox => textBox.Name == "ResultText");
            buttonC.Command.Execute(buttonC.CommandParameter);
            buttonSub.Command.Execute(buttonSub.CommandParameter);
            buttonV.Command.Execute(buttonV.CommandParameter);
            buttonResult.Command.Execute(buttonResult.CommandParameter);

            await Task.Delay(50);
            string text = result.Text;
            buttonCE.Command.Execute(buttonCE.CommandParameter);
            Assert.True(text == "XCV", "!XCV");

            
            buttonC.Command.Execute(buttonC.CommandParameter);
            buttonSub.Command.Execute(buttonSub.CommandParameter);
            buttonX.Command.Execute(buttonX.CommandParameter);
            buttonC.Command.Execute(buttonC.CommandParameter);
            buttonResult.Command.Execute(buttonResult.CommandParameter);

            await Task.Delay(50);
            text = result.Text;
            buttonCE.Command.Execute(buttonCE.CommandParameter);
            Assert.True(text == "X", "!X");
        }
        [Fact]
        public async void TestMultiplication()
        {
            var app = AvaloniaApp.GetApp();
            var mainWindow = AvaloniaApp.GetMainWindow();

            await Task.Delay(100);

            var buttonI = mainWindow.GetVisualDescendants().OfType<Button>().First(b => b.Name == "buttonI");
            var buttonM = mainWindow.GetVisualDescendants().OfType<Button>().First(b => b.Name == "buttonM");
            var buttonV = mainWindow.GetVisualDescendants().OfType<Button>().First(b => b.Name == "buttonV");
            var buttonResult = mainWindow.GetVisualDescendants().OfType<Button>().First(b => b.Name == "buttonResult");
            var buttonMul = mainWindow.GetVisualDescendants().OfType<Button>().First(b => b.Name == "buttonMul");
            var buttonCE = mainWindow.GetVisualDescendants().OfType<Button>().First(b => b.Name == "buttonCE");
            var result = mainWindow.GetVisualDescendants().OfType<TextBlock>().First(textBox => textBox.Name == "ResultText");
            buttonV.Command.Execute(buttonV.CommandParameter);
            buttonMul.Command.Execute(buttonMul.CommandParameter);
            buttonV.Command.Execute(buttonV.CommandParameter);
            buttonResult.Command.Execute(buttonResult.CommandParameter);

            await Task.Delay(50);
            string text = result.Text;
            buttonCE.Command.Execute(buttonCE.CommandParameter);
            Assert.True(text == "XXV", "!XXV");


            buttonM.Command.Execute(buttonM.CommandParameter);
            buttonMul.Command.Execute(buttonMul.CommandParameter);
            buttonI.Command.Execute(buttonI.CommandParameter);
            buttonI.Command.Execute(buttonI.CommandParameter);
            buttonResult.Command.Execute(buttonResult.CommandParameter);

            await Task.Delay(50);
            text = result.Text;
            buttonCE.Command.Execute(buttonCE.CommandParameter);
            Assert.True(text == "MM", "!MM");
        }
        [Fact]
        public async void TestDIV ()
        {
            var app = AvaloniaApp.GetApp();
            var mainWindow = AvaloniaApp.GetMainWindow();

            await Task.Delay(100);

            var buttonI = mainWindow.GetVisualDescendants().OfType<Button>().First(b => b.Name == "buttonI");
            var buttonC = mainWindow.GetVisualDescendants().OfType<Button>().First(b => b.Name == "buttonC");
            var buttonX = mainWindow.GetVisualDescendants().OfType<Button>().First(b => b.Name == "buttonX");
            var buttonV = mainWindow.GetVisualDescendants().OfType<Button>().First(b => b.Name == "buttonV");
            var buttonM = mainWindow.GetVisualDescendants().OfType<Button>().First(b => b.Name == "buttonM");
            var buttonResult = mainWindow.GetVisualDescendants().OfType<Button>().First(b => b.Name == "buttonResult");
            var buttonDIV = mainWindow.GetVisualDescendants().OfType<Button>().First(b => b.Name == "buttonDiv");
            var buttonCE = mainWindow.GetVisualDescendants().OfType<Button>().First(b => b.Name == "buttonCE");
            var result = mainWindow.GetVisualDescendants().OfType<TextBlock>().First(textBox => textBox.Name == "ResultText");
            buttonC.Command.Execute(buttonC.CommandParameter);
            buttonDIV.Command.Execute(buttonDIV.CommandParameter);
            buttonV.Command.Execute(buttonV.CommandParameter);
            buttonResult.Command.Execute(buttonResult.CommandParameter);

            await Task.Delay(50);
            string text = result.Text;
            buttonCE.Command.Execute(buttonCE.CommandParameter);
            Assert.True(text == "XX", "!XX");


            buttonC.Command.Execute(buttonC.CommandParameter);
            buttonV.Command.Execute(buttonV.CommandParameter);
            buttonDIV.Command.Execute(buttonDIV.CommandParameter);
            buttonI.Command.Execute(buttonI.CommandParameter);
            buttonI.Command.Execute(buttonI.CommandParameter);
            buttonI.Command.Execute(buttonI.CommandParameter);
            buttonResult.Command.Execute(buttonResult.CommandParameter);

            await Task.Delay(50);
            text = result.Text;
            buttonCE.Command.Execute(buttonCE.CommandParameter);
            Assert.True(text == "XXXV", "!XXXV");
        }
        [Fact]
        public async void TestERROR()
        {
            var app = AvaloniaApp.GetApp();
            var mainWindow = AvaloniaApp.GetMainWindow();

            await Task.Delay(100);

            var buttonX = mainWindow.GetVisualDescendants().OfType<Button>().First(b => b.Name == "buttonX");
            var buttonM = mainWindow.GetVisualDescendants().OfType<Button>().First(b => b.Name == "buttonM");
            var buttonResult = mainWindow.GetVisualDescendants().OfType<Button>().First(b => b.Name == "buttonResult");
            var buttonPls = mainWindow.GetVisualDescendants().OfType<Button>().First(b => b.Name == "buttonPlus");
            var buttonDIV = mainWindow.GetVisualDescendants().OfType<Button>().First(b => b.Name == "buttonDiv");
            var buttonSub = mainWindow.GetVisualDescendants().OfType<Button>().First(b => b.Name == "buttonSub");
            var buttonMul = mainWindow.GetVisualDescendants().OfType<Button>().First(b => b.Name == "buttonMul");
            var buttonCE = mainWindow.GetVisualDescendants().OfType<Button>().First(b => b.Name == "buttonCE");
            var result = mainWindow.GetVisualDescendants().OfType<TextBlock>().First(textBox => textBox.Name == "ResultText");
            
            buttonX.Command.Execute(buttonX.CommandParameter);
            buttonDIV.Command.Execute(buttonDIV.CommandParameter);
            buttonM.Command.Execute(buttonM.CommandParameter);
            buttonResult.Command.Execute(buttonResult.CommandParameter);

            await Task.Delay(50);
            string text = result.Text;
            buttonCE.Command.Execute(buttonCE.CommandParameter);
            Assert.True(text == "#ERROR", "!ERROR");


            buttonM.Command.Execute(buttonM.CommandParameter);
            buttonSub.Command.Execute(buttonSub.CommandParameter);
            buttonM.Command.Execute(buttonM.CommandParameter);
            buttonResult.Command.Execute(buttonResult.CommandParameter);

            await Task.Delay(50);
            text = result.Text;
            buttonCE.Command.Execute(buttonCE.CommandParameter);
            Assert.True(text == "#ERROR", "!ERROR");

            buttonM.Command.Execute(buttonM.CommandParameter);
            buttonM.Command.Execute(buttonM.CommandParameter);
            buttonM.Command.Execute(buttonM.CommandParameter);
            buttonPls.Command.Execute(buttonPls.CommandParameter);
            buttonM.Command.Execute(buttonM.CommandParameter);
            buttonResult.Command.Execute(buttonResult.CommandParameter);

            await Task.Delay(50);
            text = result.Text;
            buttonCE.Command.Execute(buttonCE.CommandParameter);
            Assert.True(text == "#ERROR", "!ERROR");

            buttonM.Command.Execute(buttonM.CommandParameter);
            buttonMul.Command.Execute(buttonMul.CommandParameter);
            buttonM.Command.Execute(buttonM.CommandParameter);
            buttonResult.Command.Execute(buttonResult.CommandParameter);

            await Task.Delay(50);
            text = result.Text;
            buttonCE.Command.Execute(buttonCE.CommandParameter);
            Assert.True(text == "#ERROR", "!ERROR");



        }




    }
}