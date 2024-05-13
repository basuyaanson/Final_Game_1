namespace WinFormsApp2
{
    public partial class Form_Game : Form
    {
        public Form_Game()
        {
            InitializeComponent();
            InitialGame();

        }

        //�C����l��
        public void InitialGame()
        {
            //�p�ɾ�
            Game_Tick.Start();
            //��H
            SingleObject.GetSingle().AddGameObject(new Hero(0, 0, SingleObject.GetSingle().Wp));//�s�W���a
            SingleObject.GetSingle().AddGameObject(new B(100, 100, SingleObject.GetSingle().Hero));//�s�W�Ǥ�
            /*
            //AllocConsole();
           
            GameStart.Start();
            PlayeTime.Start();
            Hold = false;
            this.TimeCount = 1;
            LevelUpSelcet();
            //�s�W����icon
            Bitmap bitmap = (Bitmap)Bitmap.FromFile(@"..\..\..\Asset\aim.ico");
            this.Cursor = new Cursor(bitmap.GetHicon());

            //�g�t
            Timer_Fire.Interval = SingleObject.GetSingle().H.shootSpeed;
            //
            Console.WriteLine("�ͦ����\");*/
        }


        //---------------�ƹ�

        //�ƹ�����
        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            //SingleObject.GetSingle().Aa.MouseMove(e);
        }
        
        //���U��L
        private void Form_Game_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == PlayerInput.keyup)
            {
                PlayerInput.IsUp = true;
            }
            if (e.KeyCode == PlayerInput.keydown)
            {
                PlayerInput.IsDown = true;
            }
            if (e.KeyCode == PlayerInput.keyright)
            {
                PlayerInput.IsRight = true;
            }
            if (e.KeyCode == PlayerInput.keyleft)
            {
                PlayerInput.IsLeft = true;
            }
           /* if (e.KeyCode == PlayerInput.keyP)
            {
                Console.WriteLine("���U");
                if (PlayerInput.IsP == true)
                {
                    PlayeTime.Start();
                    GameStart.Start();
                    P_Meun.Hide();
                    PlayerInput.IsP = false;
                    Console.WriteLine("�}�l");
                }
                else if (PlayerInput.IsP == false)
                {
                    PlayeTime.Stop();
                    GameStart.Stop();
                    P_Meun.Show();
                    PlayerInput.IsP = true;
                    Console.WriteLine("�Ȱ�");
                }
            }*/
        }
        
        //��}��L
        private void Form_Game_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == PlayerInput.keyup)
                PlayerInput.IsUp = false;
            if (e.KeyCode == PlayerInput.keydown)
                PlayerInput.IsDown = false;
            if (e.KeyCode == PlayerInput.keyright)
                PlayerInput.IsRight = false;
            if (e.KeyCode == PlayerInput.keyleft)
                PlayerInput.IsLeft = false;

        }

        //---------------�p�ɾ�

        //�e����s ���a���ʨ�s
        private void Game_Tick_Event(object sender, EventArgs e)
        {
           if (PlayerInput.IsUp && SingleObject.GetSingle().Hero.y >= 10)
            {
                SingleObject.GetSingle().Hero.y -= (int)SingleObject.GetSingle().Hero.Speed;
            }
            if (PlayerInput.IsDown && SingleObject.GetSingle().Hero.y <= 790)
            {
                SingleObject.GetSingle().Hero.y += (int)SingleObject.GetSingle().Hero.Speed;
            }
            if (PlayerInput.IsLeft && SingleObject.GetSingle().Hero.x >= 10)
            {
                SingleObject.GetSingle().Hero.x -= (int)SingleObject.GetSingle().Hero.Speed;
            }
            if (PlayerInput.IsRight && SingleObject.GetSingle().Hero.x <= 1530)
            {
                SingleObject.GetSingle().Hero.x += (int)SingleObject.GetSingle().Hero.Speed;
            }
            this.Invalidate();
        }

        //---------------���f�ƥ�

        //���J�e���ɽե�
        private void Form_Game_Load(object sender, EventArgs e)
        {
            //�N�Ϲ�ø�s��w�s�ϡA�ѨM�{�̪����D
            this.SetStyle
                (ControlStyles.OptimizedDoubleBuffer |
                ControlStyles.AllPaintingInWmPaint |
                ControlStyles.ResizeRedraw,
                true);
        }

        //�e����s�ե�
        private void Form_Game_Paint(object sender, PaintEventArgs e)
        {
            SingleObject.GetSingle().DrwaGameObject(e.Graphics);
        }

     
    }
}
