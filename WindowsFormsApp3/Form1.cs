using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApp3
{

    public partial class Form1 : Form
    {

        DrawGraph G;
        List<Vertex> V;
        List<Edge> E;
        List<Neighbor> N;
        Random x = new Random();
        int[,] AMatrix; //матрица смежности
        int selected1; //выбранные вершины, для соединения линиями
        int selected2;

        public Form1()
        {
            InitializeComponent();
            V = new List<Vertex>();
            G = new DrawGraph(sheet.Width, sheet.Height);
            E = new List<Edge>();
            N = new List<Neighbor>();
            sheet.Image = G.GetBitmap();
        }

        //кнопка - выбрать вершину
        private void SelectB_Click(object sender, EventArgs e)
        {
            SelectB.Enabled = false;
            VertexB.Enabled = true;
            EdgeB.Enabled = true;
            G.clearSheet();
            G.drawALLGraph(V, E);
            sheet.Image = G.GetBitmap();
            selected1 = -1;
        }

        //кнопка - рисовать вершину
        private void VertexB_Click(object sender, EventArgs e)
        {
            VertexB.Enabled = false;
            SelectB.Enabled = true;
            EdgeB.Enabled = true;
            G.clearSheet();
            G.drawALLGraph(V, E);
            sheet.Image = G.GetBitmap();
        }

        //кнопка - рисовать ребро
        private void EdgeB_Click(object sender, EventArgs e)
        {
            EdgeB.Enabled = false;
            SelectB.Enabled = true;
            VertexB.Enabled = true;
            G.clearSheet();
            G.drawALLGraph(V, E);
            sheet.Image = G.GetBitmap();
            selected1 = -1;
            selected2 = -1;
        }

        //кнопка - матрица смежности
        private void AdjB_Click(object sender, EventArgs e)
        {
            createAdjAndOut();
        }

        //кнопка - рассчет пути
        private void Shw_Click(object sender, EventArgs e)
        {
            shortestway();
        }

        private void sheet_MouseClick(object sender, MouseEventArgs e)
        {
            int rand = x.Next(1, 10);
            bool metka = false;
            if (SelectB.Enabled == false)
            {
                for (int i = 0; i < V.Count; i++)
                {
                    if (Math.Pow((V[i].x - e.X), 2) + Math.Pow((V[i].y - e.Y), 2) <= G.R * G.R)
                    {
                        if (selected1 != -1)
                        {
                            selected1 = -1;
                            G.clearSheet();
                            G.drawALLGraph(V, E);
                            sheet.Image = G.GetBitmap();
                        }
                    }
                }
            }
            // добавление вершины
            if (VertexB.Enabled == false)
            {
                V.Add(new Vertex(e.X, e.Y, metka, rand));
                G.drawVertex(e.X, e.Y, V.Count.ToString(), metka);
                sheet.Image = G.GetBitmap();
            }

            // добавление ребра
            if (EdgeB.Enabled == false)
            {
                if (e.Button == MouseButtons.Left)
                {
                    for (int i = 0; i < V.Count; i++)
                    {
                        if (Math.Pow((V[i].x - e.X), 2) + Math.Pow((V[i].y - e.Y), 2) <= G.R * G.R)
                        {
                            if (selected1 == -1)
                            {
                                G.drawSelectedVertex(V[i].x, V[i].y);
                                selected1 = i;
                                sheet.Image = G.GetBitmap();
                                break;
                            }
                            if (selected2 == -1)
                            {
                                G.drawSelectedVertex(V[i].x, V[i].y);
                                selected2 = i;
                                E.Add(new Edge(selected1, selected2, rand));
                                G.drawEdge(V[selected1], V[selected2], E[E.Count - 1], rand);
                                selected1 = -1;
                                selected2 = -1;
                                sheet.Image = G.GetBitmap();
                                break;
                            }
                        }
                    }
                }
                if (e.Button == MouseButtons.Right)
                {
                    if ((selected1 != -1) &&
                        (Math.Pow((V[selected1].x - e.X), 2) + Math.Pow((V[selected1].y - e.Y), 2) <= G.R * G.R))
                    {
                        G.drawVertex(V[selected1].x, V[selected1].y, (selected1 + 1).ToString(), metka);
                        selected1 = -1;
                        sheet.Image = G.GetBitmap();
                    }
                }
            }
        }

        //матрица инцидентности
        private void createAdjAndOut()
        {
            AMatrix = new int[V.Count, V.Count];
            G.fillAdjacencyMatrix(V.Count, E, AMatrix);
            listBoxMatrix.Items.Clear();
            string sOut = "    ";
            for (int i = 0; i < V.Count; i++)
                sOut += (i + 1) + " ";
            listBoxMatrix.Items.Add(sOut);
            for (int i = 0; i < V.Count; i++)
            {
                sOut = (i + 1) + " | ";
                for (int j = 0; j < V.Count; j++)
                    sOut += AMatrix[i, j] + " ";
                listBoxMatrix.Items.Add(sOut);
            }
        }

        //поиск самого короткого пути
        private void shortestway()
        {

            try
            {
                int w = 0;
                int c = int.Parse(textBox1.Text);
                int c1 = int.Parse(textBox2.Text);
                const string caption = "Ошибка: Вершина не найдена";
                int q = V.Count;
                if (c > V.Count || c1 > V.Count)
                {
                    listBox1.Items.Clear();
                    MessageBox.Show(caption);
                }
                else if (c < 1 || c1 < 1)
                {
                    listBox1.Items.Clear();
                    MessageBox.Show("Ошибка: имя вершины не может быть меньше 1");
                }
                else if (c <= V.Count && c1 <= V.Count)
                {
                    listBox1.Items.Clear();
                    int r = G.deija(E, V, N, w, c, c1);
                    if (r == int.MaxValue)
                    {
                        const string capt = "Ошибка: недосягаемая вершина";
                        MessageBox.Show(capt);
                    }
                    else
                    {
                        listBox1.Items.Add(r);
                    }
                }
            }
            catch (FormatException)
            {
                const string caption1 = "Ошибка: Неверное имя вершины";
                MessageBox.Show(caption1);
            }

            
            
        }


    }
}
