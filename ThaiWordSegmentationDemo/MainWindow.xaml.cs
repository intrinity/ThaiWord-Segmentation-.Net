using System.Collections.Generic;
using System.Text;
using System.Windows;
using ThaiSplitLib;
using THSplit;

namespace ThaiWordSegmentationDemo
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void MainWindow_OnLoaded(object sender, RoutedEventArgs e)
        {
            string inputText = "โนเจโชว์เสน่ห์ของเธอผ่านการร่วมงานกับนิตยสาร Your Vibes พร้อมกับเล่าถึงความรู้สึกที่มีต่อกระแสความนิยมของเธอที่เกดขึ้นจากรายการ Street Woman Fighters โนเจได้พูดถึงความรู้สึกของเธอต่อกระแสความนิยมที่เกิดขึ้นอย่างรวดเร็ว หลังจากการปรากฎตัวร่วมแข่งขันในรายการ Street Woman Fighter ซึ่งทำให้การใช้ชีวิตของเธอต้องเปลี่ยนไป รวมถึงเรื่องราวส่วนตัวของเธอที่ถูกพูดถึงมากขึ้น \"ฉันรู้สึกเซอร์ไพรส์และขอบคุณมากๆ ค่ะ ที่หลายๆ คนจดจำฉันได้  ซึ่งมันก็เป็นอะไรที่หลีกเลี่ยงไม่ได้จริงๆ ในเรื่องของความเป็นส่วนตัวที่ต้องเปลี่ยนแปลงไป ซึ่งจริงๆ แล้วฉันก็โอเคกับสิ่งที่เกิดขึ้น แต่มันก็มีเรื่องส่วนตัวบางอย่าง อย่างเช่นเรื่องในอดีตที่ตัวฉันเองก็รู้สึกอายเหมือนกันนะคะที่บางเรื่องก็ถูกพูดถึงออกมา\"";

            Spliter spliter = new Spliter();
            //List<string> segmentedText = spliter.SegmentByDictionary(inputText);

            //StringBuilder builder = new StringBuilder();
            //int characterCountPerLine = 30;
            //string currentLineText = string.Empty;
            //foreach (var word in segmentedText)
            //{
            //    if (currentLineText.LengthTH() + word.LengthTH() > characterCountPerLine)
            //    {
            //        builder.AppendLine(currentLineText.Trim());
            //        currentLineText = word;
            //        continue;
            //    }

            //    currentLineText += word;
            //}

            txbMessage.Text = spliter.LineSegmentByDictionary(inputText, 50);
        }
    }
}
