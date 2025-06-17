using MahApps.Metro.Controls;
using System.Diagnostics;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Media.Animation;

namespace WpfIoTSimulatorApp.Views
{
    /// <summary>
    /// MainView.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class MainView : MetroWindow
    {
        public MainView()
        {
            InitializeComponent();
        }
        //Timer timer = new Timer();
        Stopwatch sw = new Stopwatch();

        private void BtnTest_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            StartHmiAni(); // Hmi 애니메이션 동작
        }

        // WPF 상의 객체 애니메이션 추가
        private void StartHmiAni()
        {
            Product.Fill = new SolidColorBrush(Colors.Gray);    // 제품을 회색으로 칠하기

            // 기어애니메이션
            DoubleAnimation ga = new DoubleAnimation();
            ga.From = 0;
            ga.To = 360;
            ga.Duration = TimeSpan.FromSeconds(5);  // 계획 로드타임(Schedules의 LoadTime 값이 들어가야 함)

            RotateTransform rt = new RotateTransform();
            GearStart.RenderTransform = rt;
            GearStart.RenderTransformOrigin = new System.Windows.Point(0.5, 0.5);
            GearEnd.RenderTransform = rt;
            GearEnd.RenderTransformOrigin = new System.Windows.Point(0.5, 0.5);

            rt.BeginAnimation(RotateTransform.AngleProperty, ga);

            // 제품 애니메이션
            DoubleAnimation pa = new DoubleAnimation();
            pa.From = 127;
            pa.To = 422;    // x축: 센서 아래 위치
            pa.Duration = TimeSpan.FromSeconds(5);  // 계획 로드타임(Schedules의 LoadTime 값이 들어가야 함)

            Product.BeginAnimation(Canvas.LeftProperty, pa);
        }
    }
}
