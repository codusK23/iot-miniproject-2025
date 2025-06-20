using MahApps.Metro.Controls.Dialogs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfMrpSimulatorApp.Helpers
{
    /// <summary>
    /// 프로젝트 내에서 공통으로 사용하는 정적 클래스
    /// 클래스 자체가 static일 필요는 없음. 사용할 변수들이 static이어야 함!
    /// </summary>
    public static class Common
    {
        // DB 연결 문자열
        public static readonly string CONNSTR = "Server=127.0.0.1;Database=miniproject;Uid=root;Pwd=12345;Charset=utf8";

        // MahApps.Metro 다이얼로그 코디네이터(MVVM에서 사용하기 위해서)
        public static IDialogCoordinator DIALOGCOORDINATOR;
    }
}
