using System;
using System.Globalization;
using System.Windows.Forms;
using imStudio.Game.EsurientSnake.Librarys;

namespace imStudio.Game.EsurientSnake
{
    public partial class frmMain : Form
    {
        private Models.ModelMap _map;
        private Models.ModelSnake _snake;
        private Models.ModelEnum.Direction _direction;
        private bool _dead;
        private bool _bonus;
        private bool _back;

        public frmMain()
        {
            InitializeComponent();
        }

        #region 初始化地图
        private void btnIniMap_Click(object sender, EventArgs e)
        {
            _map =MapHelper.GenMap(ConfigHelper.RowCount, ConfigHelper.ColCount, ConfigHelper.BoxWidth, ConfigHelper.BoxHeight,ConfigHelper.LineColor, ConfigHelper.MapColor);
            MapHelper.DrawMap(palMap, _map);
        }
        #endregion

        private void btnIniSnake_Click(object sender, EventArgs e)
        {
            _snake = SnakeHelper.GenSnake(ConfigHelper.Speed, ConfigHelper.SnakeColor);
            _snake = MapHelper.DrawSnakeOnMap(palMap, _map, _snake);
            _direction = _snake.Direction;
        }

        private void btnStartMove_Click(object sender, EventArgs e)
        {
            tmSpeed.Interval = _snake.Speed;
            tmSpeed.Tag = ConfigHelper.BonusShow.ToString(CultureInfo.InvariantCulture);
            tmSpeed.Start();
        }

        private void tmSpeed_Tick(object sender, EventArgs e)
        {
            tmSpeed.Stop();
            tmSpeed.Interval = _snake.Speed;
            _snake = MapHelper.MoveSnakeOnMap(palMap, _map, _snake, _direction, _back,out _dead);
            if (tmSpeed.Tag.ToString().Equals("0")) _map = MapHelper.ShowBonus(palMap,_map,_snake,ConfigHelper.BonusColor);
            else if (tmSpeed.Tag.ToString().Equals((ConfigHelper.BonusShow - ConfigHelper.BonusHide).ToString(CultureInfo.InvariantCulture)) && !_bonus) _map = MapHelper.HideBonus(palMap, _map);
            tmSpeed.Tag = tmSpeed.Tag.ToString().Equals("0") ? ConfigHelper.BonusShow.ToString(CultureInfo.InvariantCulture) : (int.Parse(tmSpeed.Tag.ToString()) - 1).ToString(CultureInfo.InvariantCulture);
            if (_dead) MessageBox.Show(@"Game Over");
            else tmSpeed.Start();
        }

        private void btnUp_Click(object sender, EventArgs e)
        {
            _direction = Models.ModelEnum.Direction.Up;
        }

        private void btnDown_Click(object sender, EventArgs e)
        {
            _direction = Models.ModelEnum.Direction.Down;
        }

        private void btnLeft_Click(object sender, EventArgs e)
        {
            _direction = Models.ModelEnum.Direction.Left;
        }

        private void btnRight_Click(object sender, EventArgs e)
        {
            _direction = Models.ModelEnum.Direction.Right;
        }

        private void btnSpeedPlus_Click(object sender, EventArgs e)
        {
            _snake.Speed = _snake.Speed - 100;
            _snake.Speed = _snake.Speed > 0 ? _snake.Speed:100;
        }

        private void btnSpeedMinus_Click(object sender, EventArgs e)
        {
            _snake.Speed = _snake.Speed + 100;
        }

        private void btnBonus_Click(object sender, EventArgs e)
        {
            if (btnBonus.Tag.ToString().Equals("0"))
            {
                _bonus = true;
                btnBonus.Text = @"关闭奖励永存";
                btnBonus.Tag = "1";
            }
            else
            {
                _bonus = false;
                btnBonus.Text = @"开启奖励永存";
                btnBonus.Tag = "0";
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            if (btnBack.Tag.ToString().Equals("0"))
            {
                _back = true;
                btnBack.Text = @"开启倒车功能";
                btnBack.Tag = "1";
            }
            else
            {
                _back = false;
                btnBack.Text = @"关闭倒车功能";
                btnBack.Tag = "0";
            }
        }
    }
}
