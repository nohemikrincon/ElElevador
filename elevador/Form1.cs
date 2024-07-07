using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace elevador
{
    public partial class Form1 : Form
    {
        //variables
        //cada valor es el lugar donde estan las puertas
        int y_up = 70;
        int y_mid = 330;
        int y_down = 598;
        int x_door_left_close = 77;
        int x_door_left_open = 29;
        int x_door_right_close = 129;
        int x_door_right_open = 177;

        bool go_up;
        bool go_down;
        bool go_mid;

        bool arrived_G = false;
        bool arrived_1 = false;
        bool arrived_2;

        public Form1()
        {
            InitializeComponent();
        }
        //botones
        private void btn_close_Click(object sender, EventArgs e)
        {
            if (arrived_G == true)
            {
                door_close_down();
            }
            else if (arrived_1 == true)
            {
                door_close_mid();
            }
            else if (arrived_2 == true)
            {
                door_close_up();
            }
        }

        private void btn_open_Click(object sender, EventArgs e)
        {
            if (arrived_G == true)
            {
                door_open_down();
            }
            else if (arrived_1 == true)
            {
                door_open_mid();
            }
            else if (arrived_2 == true)
            {
                door_open_up();
            }
        }

        private void btn_alarm_Click(object sender, EventArgs e)
        {
            btn_alarm.BackColor = Color.Blue;
            timer_lift_down.Enabled = false;
            timer_lift_up.Enabled = false;
            timer_lift_mid.Enabled = false;
            timer_door_open_down.Enabled = true;
            timer_door_open_up.Enabled = true;
            timer_door_open_mid.Enabled = true;

            display_panel.Image = global::elevador.Properties.Resources.alarmbellbutton;
        }
        private void btn_2_Click(object sender, EventArgs e)
        {
            btn_1.BackColor = Color.SkyBlue;
            if (!arrived_2)
            {
                going_up();
            }
        }

        private void btn_1_Click(object sender, EventArgs e)
        {
            btn_middle.BackColor = Color.SkyBlue;
            if (!arrived_1)
            {
                going_mid();
            }

        }

        private void btn_G_Click(object sender, EventArgs e)
        {
            btn_G.BackColor = Color.SkyBlue;
            if (!arrived_G)
            {
                going_down();
            }
        }


        private void btn_down_Click(object sender, EventArgs e)
        {
            btn_up.BackColor = Color.SkyBlue;
            going_up();

        }

        private void btn_mid_Click(object sender, EventArgs e)
        {
            btn_mid.BackColor = Color.SkyBlue;
            going_mid();
        }

        private void btn_up_Click(object sender, EventArgs e)
        {
            btn_down.BackColor = Color.SkyBlue;
            going_down();
        }

        //temporizadores
        //Mueve el ascensor hacia abajo
        private void timer_lift_down_Tick(object sender, EventArgs e)
        {
            if (picture_lift.Top <= y_down)
            {
                picture_lift.Top += 1;
            }
            else
            {
                timer_lift_down.Enabled = false;
                btn_up.Enabled = true;
                btn_mid.Enabled = true;
                btn_middle.Enabled = true;
                btn_1.Enabled = true;
                btn_close.Enabled = true;
                btn_open.Enabled = true;
                btn_down.BackColor = Color.SkyBlue;
                btn_G.BackColor = Color.SkyBlue;


                door_open_down();
                arrived_G = true;

                picture_lift.Image = global::elevador.Properties.Resources.Inside_of_the_lift;

                display_panel.Image = global::elevador.Properties.Resources.pb;
            }
        }
        //Mueve el ascensor hacia arriba
        private void timer_lift_up_Tick(object sender, EventArgs e)
        {
            if (picture_lift.Top >= y_up)
            {
                picture_lift.Top -= 1;
            }
            else
            {

                timer_lift_up.Enabled = false;
                btn_down.Enabled = true;
                btn_mid.Enabled = true;
                btn_middle.Enabled = true;
                btn_G.Enabled = true;
                btn_close.Enabled = true;
                btn_open.Enabled = true;
                btn_up.BackColor = Color.White;
                btn_1.BackColor = Color.White;

                door_open_up();

                picture_lift.Image = global::elevador.Properties.Resources.Inside_of_the_lift;

                display_panel.Image = global::elevador.Properties.Resources._2;
            }
        }

        // Mueve el ascensor hacia el medio, mmgva
        private void timer_lift_mid_Tick(object sender, EventArgs e)
        {
            if (picture_lift.Top != y_mid)
            {
                if (picture_lift.Top <= y_mid)
                {
                    picture_lift.Top += 1;
                }

                else
                {
                    picture_lift.Top -= 1;
                }
            }

            else
            {
                timer_lift_mid.Enabled = false;
                btn_down.Enabled = true;
                btn_mid.Enabled = true;
                btn_middle.Enabled = true;
                btn_1.Enabled = true;
                btn_G.Enabled = true;
                btn_close.Enabled = true;
                btn_open.Enabled = true;
                btn_mid.BackColor = Color.White;
                btn_1.BackColor = Color.White;

                door_open_mid();

                picture_lift.Image = global::elevador.Properties.Resources.Inside_of_the_lift;
                display_panel.Image = global::elevador.Properties.Resources._1;
            }
        }

        private void door_open_down_Tick(object sender, EventArgs e)
        {
            if (door_left_down.Left >= x_door_left_open && door_right_down.Left <= x_door_right_open)
            {
                door_left_down.Left -= 1;
                door_right_down.Left += 1;
            }
            else
            {

                timer_door_open_down.Enabled = false;

            }
        }



        private void door_close_down_Tick(object sender, EventArgs e)
        {
            if (door_left_down.Left <= x_door_left_close && door_right_down.Left >= x_door_right_close)
            {
                door_left_down.Left += 1;
                door_right_down.Left -= 1;
            }
            else
            {
                timer_door_close_down.Enabled = false;


                if (go_up == true)
                {
                    picture_lift.Image = global::elevador.Properties.Resources.lift_transparent;

                    display_panel.Image = global::elevador.Properties.Resources.up;

                    timer_lift_up.Enabled = true;
                    go_up = false;
                }

                if (go_mid == true)
                {
                    picture_lift.Image = global::elevador.Properties.Resources.lift_transparent;

                    display_panel.Image = global::elevador.Properties.Resources.up;

                    timer_lift_mid.Enabled = true;
                    go_mid = false;
                }
            }
        }

        private void timer_door_open_up_Tick(object sender, EventArgs e)
        {
            if (door_left_up.Left >= x_door_left_open && door_right_up.Left <= x_door_right_open)
            {
                door_left_up.Left -= 1;
                door_right_up.Left += 1;
            }
            else
            {
                timer_door_open_up.Enabled = false;

            }
        }

        private void timer_door_close_up_Tick(object sender, EventArgs e)
        {
            if (door_left_up.Left <= x_door_left_close && door_right_up.Left >= x_door_right_close)
            {
                door_left_up.Left += 1;
                door_right_up.Left -= 1;
            }
            else
            {
                timer_door_close_up.Enabled = false;


                if (go_down == true)
                {
                    picture_lift.Image = global::elevador.Properties.Resources.lift_transparent;

                    display_panel.Image = global::elevador.Properties.Resources.down;

                    timer_lift_down.Enabled = true;
                    go_down = false;
                }

                if (go_mid == true)
                {
                    picture_lift.Image = global::elevador.Properties.Resources.lift_transparent;

                    display_panel.Image = global::elevador.Properties.Resources.down;

                    timer_lift_mid.Enabled = true;
                    go_mid = false;
                }
            }
        }

        private void timer_door_openmid_Tick(object sender, EventArgs e)
        {
            if (door_left_mid.Left >= x_door_left_open && door_right_mid.Left <= x_door_right_open)
            {
                door_left_mid.Left -= 1;
                door_right_mid.Left += 1;
            }
            else
            {
                timer_door_open_mid.Enabled = false;
            }
        }

        private void timer_door_closemid_Tick(object sender, EventArgs e)
        {
            if (door_left_mid.Left <= x_door_left_close && door_right_mid.Left >= x_door_right_close)
            {
                door_left_mid.Left += 1;
                door_right_mid.Left -= 1;
            }
            else
            {
                timer_door_close_mid.Enabled = false;


                if (go_down == true)
                {
                    picture_lift.Image = global::elevador.Properties.Resources.lift_transparent;

                    display_panel.Image = global::elevador.Properties.Resources.down;

                    timer_lift_down.Enabled = true;
                    go_down = false;
                }

                if (go_up == true)
                {
                    picture_lift.Image = global::elevador.Properties.Resources.lift_transparent;

                    display_panel.Image = global::elevador.Properties.Resources.up;

                    timer_lift_up.Enabled = true;
                    go_up = false;
                }
            }
        }

        private void timer_lift_mid2_Tick(object sender, EventArgs e)
        {
            if (picture_lift.Top <= y_mid)
            {
                picture_lift.Top += 1;
            }
            else
            {
                timer_lift_mid.Enabled = false;
                btn_down.Enabled = true;
                btn_mid.Enabled = true;
                btn_middle.Enabled = true;
                btn_1.Enabled = true;
                btn_G.Enabled = true;
                btn_close.Enabled = true;
                btn_open.Enabled = true;
                btn_mid.BackColor = Color.White;
                btn_1.BackColor = Color.White;

                door_open_mid();

                picture_lift.Image = global::elevador.Properties.Resources.Inside_of_the_lift;
                display_panel.Image = global::elevador.Properties.Resources._1;
            }
        }


        private void btn_exit_Click(object sender, EventArgs e)
        {
            Close();
        }

        //metodos   

        private void door_close_down()
        {
            timer_door_close_down.Enabled = true;
            timer_door_open_down.Enabled = false;
        }

        private void door_open_down()
        {
            timer_door_close_down.Enabled = false;
            timer_door_open_down.Enabled = true;
        }

        private void door_close_up()
        {
            timer_door_close_up.Enabled = true;
            timer_door_open_up.Enabled = false;
        }

        private void door_open_up()
        {
            timer_door_close_up.Enabled = false;
            timer_door_open_up.Enabled = true;
        }

        private void door_close_mid()
        {
            timer_door_close_mid.Enabled = true;
            timer_door_open_mid.Enabled = false;
        }

        private void door_open_mid()
        {
            timer_door_close_mid.Enabled = false;
            timer_door_open_mid.Enabled = true;
        }

        private void going_up()
        {
            if (arrived_G)
            {
                go_up = true;
                door_close_down();
                btn_G.Enabled = false;
                btn_middle.Enabled = false;
                btn_down.Enabled = false;
                btn_mid.Enabled = false;
                btn_close.Enabled = false;
                btn_open.Enabled = false;
                arrived_G = false;
                arrived_2 = true;
                arrived_1 = false;
            }
            else
            {
                go_up = true;
                door_close_mid();
                btn_G.Enabled = false;
                btn_middle.Enabled = false;
                btn_down.Enabled = false;
                btn_mid.Enabled = false;
                btn_close.Enabled = false;
                btn_open.Enabled = false;
                arrived_G = false;
                arrived_2 = true;
                arrived_1 = false;
            }

        }

        private void going_down()
        {
            if (arrived_2)
            {
                door_close_up();
                go_down = true;
                btn_1.Enabled = false;
                btn_middle.Enabled = false;
                btn_up.Enabled = false;
                btn_mid.Enabled = false;
                btn_close.Enabled = false;
                btn_open.Enabled = false;
                arrived_1 = false;
                arrived_2 = false;
            }
            else
            {
                door_close_mid();
                go_down = true;
                btn_1.Enabled = false;
                btn_middle.Enabled = false;
                btn_up.Enabled = false;
                btn_mid.Enabled = false;
                btn_close.Enabled = false;
                btn_open.Enabled = false;
                arrived_1 = false;
                arrived_2 = false;
            }

        }

        private void going_mid()
        {
            if (arrived_G)
            {
                door_close_down();
                go_mid = true;
                btn_G.Enabled = true;
                btn_1.Enabled = false;
                btn_up.Enabled = true;
                btn_mid.Enabled = false;
                btn_down.Enabled = true;
                btn_close.Enabled = true;
                btn_open.Enabled = true;
                arrived_G = false;
                arrived_1 = true;
                arrived_2 = false;
            }
            else
            {
                door_close_up();
                go_mid = true;
                btn_G.Enabled = true;
                btn_1.Enabled = false;
                btn_up.Enabled = true;
                btn_mid.Enabled = false;
                btn_down.Enabled = true;
                btn_close.Enabled = true;
                btn_open.Enabled = true;
                arrived_G = false;
                arrived_1 = true;
                arrived_2 = false;
            }

        }
    }
}



