using System;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsScreenCap
{
    /// <summary>
    /// 画面キャプチャにスタンプを押すアプリサンプル
    /// 
    /// スタンプのアイコンは下記からお借りした
    /// https://icooon-mono.com/
    /// </summary>
    public partial class MainForm : Form
    {
        private Bitmap stamp = null;
        private (int x, int y) offset;

        public MainForm()
        {
            InitializeComponent();

            //ウィンドウを透明に
            BackColor = Color.Red;
            TransparencyKey = BackColor;
        }

        /// <summary>
        /// 画面をキャプチャ
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ScreenCap_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.Arrow;
            stamp = null;

            var screenBounds = Screen.PrimaryScreen.Bounds;
            Bitmap bmp = new Bitmap(screenBounds.Width, screenBounds.Height);

            using (Graphics graphics = Graphics.FromImage(bmp))
                graphics.CopyFromScreen(new Point(Location.X, Location.Y), new Point(-9, -31), bmp.Size);

            capImage.Image = bmp;
        }

        /// <summary>
        /// キャプチャ画面をクリックしてスタンプ貼り付け
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CapImage_Click(object sender, EventArgs e)
        {
            if(stamp != null)
            {
                MouseEventArgs mouseEvent = (MouseEventArgs)e;

                Bitmap bmp = (Bitmap)capImage.Image;

                using (Graphics graphics = Graphics.FromImage(bmp))
                    graphics.DrawImage(stamp, mouseEvent.X - offset.x, mouseEvent.Y - offset.y, stamp.Width, stamp.Height);

                capImage.Image = bmp;
            }
        }

        /// <summary>
        /// スタンプボタン押下時の処理
        /// スタンプの設定とマウスカーソルの変更
        /// </summary>
        /// <param name="icon"></param>
        /// <param name="offset_x"></param>
        /// <param name="offset_y"></param>
        private void Button_Click(Bitmap icon, int offset_x = 9, int offset_y = 9)
        {
            stamp = icon;
            Cursor = new Cursor(icon.GetHicon());
            offset = (offset_x, offset_y);
        }

        private void Button1_Click(object sender, EventArgs e) => Button_Click(Properties.Resources.check_icon);

        private void Button2_Click(object sender, EventArgs e) => Button_Click(Properties.Resources.ng_icon);


    }
}
