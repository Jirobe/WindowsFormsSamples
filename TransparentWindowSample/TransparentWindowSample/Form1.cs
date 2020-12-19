using System.Drawing;
using System.Windows.Forms;

namespace TransparentWindowSample
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //ウィンドウを透明に Start
        protected override void OnPaint(PaintEventArgs e)
        {
            //ここの色は何でもよい
            TransparencyKey = Color.Red;
            e.Graphics.FillRectangle(new SolidBrush(TransparencyKey), ClientRectangle);

            base.OnPaint(e);
        }
        //ウィンドウを透明に End
    }
}
