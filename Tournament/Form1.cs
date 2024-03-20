using Microsoft.Data.SqlClient;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using Tournament.DAL;
using Tournament.DAL.Models;
using static System.Net.Mime.MediaTypeNames;

namespace Tournament
{
    public partial class Form1 : Form
    {
        private TournamentDbContext context;

        public Form1()
        {
            InitializeComponent();
            context = new TournamentDbContext();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            List<Team> teams = context.Teams.ToList();
            dataGridView1.DataSource = teams;
            

        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            List<Team> teams = context.Teams.ToList();
            dataGridView1.DataSource = teams;         
        }

        private void allPlayersToolStripMenuItem_Click(object sender, EventArgs e)
        {

            List<Player> players = context.Players.ToList();
            dataGridView1.DataSource = players;

        }

        private void allMatchsToolStripMenuItem_Click(object sender, EventArgs e)
        {

            List<Match> matches = context.Matches.ToList();
            dataGridView1.DataSource = matches;
            
        }



        ///Search 

        private async void textBox1_TextChanged(object sender, EventArgs e)
        {
            List<Team> t = new List<Team>();

            var task = context.SearchTeamsByName(textBox1.Text);
            t = await task;

            dataGridView1.DataSource = t;
        }

        private async void textBox2_TextChanged(object sender, EventArgs e)
        {

            List<Team> t = new List<Team>();

            var task = context.SearchTeamsByCity(textBox1.Text);
            t = await task;

            dataGridView1.DataSource = t;
        }

        private void teambyNameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Visible = true;
            label1.Visible = true;

            textBox2.Visible = false;
            label2.Visible = false;
        }

        private void teambyCityToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Visible = false;
            label1.Visible = false;

            textBox2.Visible = true;
            label2.Visible = true;
        }

        private void teambyNameCityToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox2.Visible = true;
            label2.Visible = true;

            textBox1.Visible = true;
            label1.Visible = true;
        }

        ///Display Special Teams

        private async void withMostGoalsConcededToolStripMenuItem_Click(object sender, EventArgs e)
        {
            List<Team> t = new List<Team>();

            var task = context.GetTeamWithMostGoalsConcededAsync();
            Team team = await task;
            t.Add(team);

            dataGridView1.DataSource = t;
        }

        private async void withMostWinsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            List<Team> t = new List<Team>();

            var task = context.GetTeamWithMostWins();
            Team team = await task;
            t.Add(team);
            
            dataGridView1.DataSource = t;
        }

        private async void withMostLossesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            List<Team> t = new List<Team>();

            var task = context.GetTeamWithMostLosses();
            Team team = await task;
            t.Add(team);

            dataGridView1.DataSource = t;
        }

        private async void withMostDrawsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            List<Team> t = new List<Team>();

            var task = context.GetTeamWithMostDraws();
            Team team = await task;
            t.Add(team);

            dataGridView1.DataSource = t;

        }

        private async void withMostGoalsScoredToolStripMenuItem_Click(object sender, EventArgs e)
        {
            List<Team> t = new List<Team>();

            var task = context.GetTeamWithMostGoalsScored();
            Team team = await task;
            t.Add(team);

            dataGridView1.DataSource = t;
        }

        // Add Team
        private void teamToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label1.Visible = true;
            label2.Visible = true;
            label3.Visible = true;
            label4.Visible = true;
            label5.Visible = true;
            label6.Visible = true;
            label7.Visible = true;

            textBox1.Visible = true;
            textBox2.Visible = true;

            numericUpDown1.Visible = true;
            numericUpDown2.Visible = true;
            numericUpDown3.Visible = true;
            numericUpDown4.Visible = true;
            numericUpDown5.Visible = true;

            button1.Visible = true;

        }

        // Clear_All
        private void button10_Click(object sender, EventArgs e)
        {
            label1.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            label5.Visible = false;
            label6.Visible = false;
            label7.Visible = false;
            label8.Visible = false;
            label9.Visible = false;
            label10.Visible = false;
            label11.Visible = false;
            label12.Visible = false;
            label13.Visible = false;
            label14.Visible = false;
            label15.Visible = false;
            label16.Visible = false;
            label17.Visible = false;
            label18.Visible = false;
            label19.Visible = false;
            label20.Visible = false;
            label21.Visible = false;
            label22.Visible = false;

            button1.Visible = false;
            button2.Visible = false;
            button3.Visible = false;
            button4.Visible = false;
            button5.Visible = false;
            button6.Visible = false;
            button7.Visible = false;
            button8.Visible = false;
            button9.Visible = false;

            textBox1.Visible = false;
            textBox1.Text = "";
            textBox2.Visible = false;
            textBox2.Text = "";
            textBox3.Visible = false;
            textBox3.Text = "";
            textBox4.Visible = false;
            textBox4.Text = "";
            textBox5.Visible = false;
            textBox5.Text = "";
            textBox6.Visible = false;
            textBox6.Text = "";
            textBox7.Visible = false;
            textBox7.Text = "";
            textBox8.Visible = false;
            textBox8.Text = "";
            textBox9.Visible = false;
            textBox9.Text = "";
            textBox10.Visible = false;
            textBox10.Text = "";
            textBox11.Visible = false;
            textBox11.Text = "";

            numericUpDown1.Visible = false;
            numericUpDown1.Value = 0;
            numericUpDown2.Visible = false;
            numericUpDown2.Value = 0;
            numericUpDown3.Visible = false;
            numericUpDown3.Value = 0;
            numericUpDown4.Visible = false;
            numericUpDown4.Value = 0;
            numericUpDown5.Visible = false;
            numericUpDown5.Value = 0;
            numericUpDown6.Visible = false;
            numericUpDown6.Value = 0;
            numericUpDown7.Visible = false;
            numericUpDown7.Value = 0;
            numericUpDown8.Visible = false;
            numericUpDown8.Value = 0;

            dateTimePicker1.Visible = false;
            dateTimePicker2.Visible = false;
            dateTimePicker3.Visible = false;

            dataGridView1.DataSource = null;


        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                var te = new Team()
                {
                    Name = textBox1.Text,
                    City = textBox2.Text,
                    Wins = (int)numericUpDown1.Value,
                    Losses = (int)numericUpDown2.Value,
                    Draws = (int)numericUpDown3.Value,
                    GoalsScored = (int)numericUpDown4.Value,
                    GoalsConceded = (int)numericUpDown5.Value
                };

                context.Teams.Add(te);
                context.SaveChanges();
                dataGridView1.DataSource = context.Teams.ToList();
            }
        }

        private void teamToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            button2.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {

                List<Team> t = context.Teams.ToList();
                context.Teams.Remove(t[this.dataGridView1.SelectedRows[0].Index]);
                context.SaveChanges();
                dataGridView1.DataSource = context.Teams.ToList();
            

        }

        private void teamToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            label1.Visible = true;
            label2.Visible = true;
            label3.Visible = true;
            label4.Visible = true;
            label5.Visible = true;
            label6.Visible = true;
            label7.Visible = true;

            textBox1.Visible = true;
            textBox2.Visible = true;

            numericUpDown1.Visible = true;
            numericUpDown2.Visible = true;
            numericUpDown3.Visible = true;
            numericUpDown4.Visible = true;
            numericUpDown5.Visible = true;

            button3.Visible = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                var te = new Team()
                {
                    Name = textBox1.Text,
                    City = textBox2.Text,
                    Wins = (int)numericUpDown1.Value,
                    Losses = (int)numericUpDown2.Value,
                    Draws = (int)numericUpDown3.Value,
                    GoalsScored = (int)numericUpDown4.Value,
                    GoalsConceded = (int)numericUpDown5.Value
                };

                    List<Team> t = context.Teams.ToList();
                    te.Id = this.dataGridView1.SelectedRows[0].Index;
                    context.Teams.ToList()[this.dataGridView1.SelectedRows[0].Index] = te;

                    context.SaveChanges();
                    dataGridView1.DataSource = context.Teams.ToList();


            }
        }

        private void playerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label8.Visible = true;
            label9.Visible = true;
            label10.Visible = true;
            label11.Visible = true;
            label12.Visible = true;


            textBox3.Visible = true;
            textBox4.Visible = true;
            textBox5.Visible = true;
            textBox6.Visible = true;

            numericUpDown6.Visible = true;

            button4.Visible = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {

            if (textBox3.Text != "")
            {
                var tet = new Player()
                {
                    FullName = textBox3.Text,
                    Country = textBox4.Text,
                    ShirtNumber = (int)numericUpDown6.Value,
                    Position = textBox5.Text,
                    TeamId = int.Parse(textBox6.Text)
                };


                context.Players.Add(tet);
                context.SaveChanges();
                dataGridView1.DataSource = context.Players.ToList();
            }
        }

        private void playerToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            button5.Visible = true;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            using (TournamentDbContext context = new TournamentDbContext())
            {
                List<Player> p = context.Players.ToList();
                context.Players.Remove(p[this.dataGridView1.SelectedRows[0].Index]);
                context.SaveChanges();
                dataGridView1.DataSource = context.Players.ToList();
            }
        }

        private void playerToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            label8.Visible = true;
            label9.Visible = true;
            label10.Visible = true;
            label11.Visible = true;
            label12.Visible = true;


            textBox3.Visible = true;
            textBox4.Visible = true;
            textBox5.Visible = true;
            textBox6.Visible = true;

            numericUpDown6.Visible = true;

            button6.Visible = true;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (textBox3.Text != "")
            {
                var tet = new Player()
                {
                    FullName = textBox3.Text,
                    Country = textBox4.Text,
                    ShirtNumber = (int)numericUpDown6.Value,
                    Position = textBox5.Text,
                    TeamId = int.Parse(textBox6.Text)
                };



                    List<Player> p = context.Players.ToList();
                    tet.Id = this.dataGridView1.SelectedRows[0].Index;
                    context.Players.ToList()[this.dataGridView1.SelectedRows[0].Index] = tet;

                    context.SaveChanges();
                    dataGridView1.DataSource = context.Players.ToList();

                
            }
        }

        private void matchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label17.Visible = true;
            label18.Visible = true;
            label19.Visible = true;
            label20.Visible = true;
            label21.Visible = true;
            label22.Visible = true;


            textBox7.Visible = true;
            textBox8.Visible = true;
            textBox9.Visible = true;

            numericUpDown7.Visible = true;
            numericUpDown8.Visible = true;

            dateTimePicker1.Visible = true;

            button7.Visible = true;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (textBox7.Text != "")
            {
                var te = new Match()
                {
                    Team1Id = int.Parse(textBox7.Text),
                    Team2Id = int.Parse(textBox8.Text),
                    GoalsTeam1 = (int)numericUpDown7.Value,
                    GoalsTeam2 = (int)numericUpDown8.Value,
                    Scorer = textBox9.Text,
                    MatchDate = dateTimePicker1.Value
                };

                context.Matches.Add(te);
                context.SaveChanges();
                dataGridView1.DataSource = context.Matches.ToList();
            }
        }

        private void matchToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            button8.Visible = true;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            using (TournamentDbContext context = new TournamentDbContext())
            {
                List<Match> p = context.Matches.ToList();
                context.Matches.Remove(p[this.dataGridView1.SelectedRows[0].Index]);
                context.SaveChanges();
                dataGridView1.DataSource = context.Matches.ToList();
            }
        }

        private void matchToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            label17.Visible = true;
            label18.Visible = true;
            label19.Visible = true;
            label20.Visible = true;
            label21.Visible = true;
            label22.Visible = true;


            textBox7.Visible = true;
            textBox8.Visible = true;
            textBox9.Visible = true;

            numericUpDown7.Visible = true;
            numericUpDown8.Visible = true;

            dateTimePicker1.Visible = true;

            button9.Visible = true;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (textBox7.Text != "")
            {
                var te = new Match()
                {
                    Team1Id = int.Parse(textBox7.Text),
                    Team2Id = int.Parse(textBox8.Text),
                    GoalsTeam1 = (int)numericUpDown7.Value,
                    GoalsTeam2 = (int)numericUpDown8.Value,
                    Scorer = textBox9.Text,
                    MatchDate = dateTimePicker1.Value
                };



                    List<Match> p = context.Matches.ToList();
                    te.Id = this.dataGridView1.SelectedRows[0].Index;
                    context.Matches.ToList()[this.dataGridView1.SelectedRows[0].Index] = te;

                    context.SaveChanges();
                    dataGridView1.DataSource = context.Matches.ToList();

                
            }
        }
    }
}
