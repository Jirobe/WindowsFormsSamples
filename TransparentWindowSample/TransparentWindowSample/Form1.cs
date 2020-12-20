using System.Drawing;
using System.Windows.Forms;

namespace TransparentWindowSample
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            //①ウィンドウを透明に Start
            //Form.TransparencyKey プロパティ
            //https://docs.microsoft.com/ja-jp/dotnet/api/system.windows.forms.form.transparencykey?view=net-5.0
            //ここの色は何でもよい
            BackColor = Color.Red;
            // Make the background color of form display transparently.
            TransparencyKey = BackColor;
            //①ウィンドウを透明に End
        }

        //②ウィンドウを透明に Start
        //protected override void OnPaint(PaintEventArgs e)
        //{
        //    //ここの色は何でもよい
        //    TransparencyKey = Color.Red;
        //    e.Graphics.FillRectangle(new SolidBrush(TransparencyKey), ClientRectangle);

        //    base.OnPaint(e);
        //}
        //②ウィンドウを透明に End
    }
}
