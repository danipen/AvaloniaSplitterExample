using AvaloniaEdit;
using Avalonia.Controls;
using Avalonia.Media;

namespace AvaloniaSplitterExample
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            TextEditor leftEditor = new TextEditor();
            leftEditor.Background = Brushes.White;
            leftEditor.Text = SRC_FILE;
            leftEditor.FontFamily = new FontFamily("Consolas");
            leftEditor.FontSize = 12;

            TextEditor baseEditor = new TextEditor();
            baseEditor.Background = Brushes.White;
            baseEditor.Text = BASE_FILE;
            baseEditor.FontFamily = new FontFamily("Consolas");
            baseEditor.FontSize = 12;

            TextEditor rightEditor = new TextEditor();
            rightEditor.Background = Brushes.White;
            rightEditor.Text = DST_FILE;
            rightEditor.FontFamily = new FontFamily("Consolas");
            rightEditor.FontSize = 12;

            DockPanel leftPanel = this.FindControl<DockPanel>("mLeftEditorPanel");
            DockPanel basePanel = this.FindControl<DockPanel>("mBaseEditorPanel");
            DockPanel rightPanel = this.FindControl<DockPanel>("mRightEditorPanel");

            leftPanel.Children.Add(leftEditor);
            basePanel.Children.Add(baseEditor);
            rightPanel.Children.Add(rightEditor);
        }

                const string SRC_FILE =
@"using System;

namespace Example1
{
    public static class ExampleClass
    {
         public int Main(string[] args)
         {
              // this is added on source

              // this program just displays a string with a very very very very very very very very very very very very very very very very long line (2!)
              // using the Console
              // for demonstration purposes

              // this program just displays a string
              // using the Console
              // for demonstration purposes

              // this program just displays a string
              // src
              // l1
              // l2
              // l3
              // l4
              // using the Console
              // for demonstration purposes

              // this program just displays a string
              // using the Console
              // for demonstration purposes

              // this program just displays a string
              // using the Console
              // for demonstration purposes

              // this program just displays a string
              // using the Console
              // for demonstration purposes

              // this program just displays a string
              // using the Console
              // for demonstration purposes

              // block src
              string output = ""this string is created on src"";
              // block src

              Console.WriteLine(output);
         }
    }
}";

        const string BASE_FILE =
@"using System;

namespace Example1
{
    public static class ExampleClass
    {
         public int Main(string[] args)
         {
              // this program just displays a string with a very very very very very very very very very very very very very very very very long line (1)
              // using the Console
              // for demonstration purposes

              // extra line

              // this program just displays a string
              // using the Console
              // for demonstration purposes

              // this program just displays a string
              // using the Console
              // for demonstration purposes

              // this program just displays a string
              // using the Console
              // for demonstration purposes

              // this program just displays a string
              // using the Console
              // for demonstration purposes

              // this program just displays a string
              // using the Console
              // for demonstration purposes

              // this program just displays a string
              // using the Console
              // for demonstration purposes

              // block base
              string output = ""this string is created on base"";
              // block base

              Console.WriteLine(output);
         }
    }
}";

        const string DST_FILE =
@"using System;

namespace Example1
{
    public static class ExampleClass
    {
         public int Main(string[] args)
         {
              // this program just displays a string with a very very very very very very very very very very very very very very very very long line (3)
              // using the Console
              // for demonstration purposes

              // extra line

              // this program just displays a string
              // using the Console
              // for demonstration purposes

              // this program just displays a string
              // l1
              // l2
              // l3
              // l4
              // dst
              // using the Console
              // for demonstration purposes

              // this program just displays a string
              // using the Console
              // for demonstration purposes

              // this program just displays a string
              // using the Console
              // for demonstration purposes

              // this program just displays a string
              // using the Console
              // for demonstration purposes

              // this program just displays a string
              // using the Console
              // for demonstration purposes

              // block dst
              string output = ""this string is created on dst"";
              // block dst

              Console.WriteLine(output);

              // added stuff on dst
         }
    }
}";
    }
}