using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GorgKaimon
{
    public partial class Form1 : Form
    {
        Size_ size_;
        //Size_ panel_size_;
        //Neyron_DB neyrons;
        NeyGorge n;
        //List<object> elements__;
        List<bool> __ns;
        string object_data;
        elements_ el;
        

        public Form1()
        {            
            InitializeComponent();
            size_ = new Size_(Height, Width);
   //         panel_size_ = new Size_(panel1.Height, panel1.Width);
            this.HandleCreated += Created;
            this.SizeChanged += SizeChange;            
            //neyrons = new Neyron_DB();
            __ns = new List<bool>();
            add_but.Click += add_element;
            Refresh();
            n = new NeyGorge();
            el = new elements_();
            //elements__ = new List<element_>();
            //n.test();
            console_button.Click += Console_button_Click;
            object_data = "";
        }

        private void open_file()
        {
            OpenFileDialog fd = new OpenFileDialog();
            fd.ShowDialog();
            StreamReader r = new StreamReader(fd.FileName);
            
            object_data = "";
            int r_ = 0;
            while ((r_ = r.Read()) != -1)
            {
                object_data += Convert.ToChar(r_);
            }
            r.Close();
        }

        private void create_element(int x, int y, string args, char type)
        {
                        
            el.add_element(elements_.NEYRON, 12, 12, panel1, n.DATA_BASE);
            panel1.Refresh();
            
        }

        private void Console_button_Click(object sender, EventArgs e)
        {
            //throw new NotImplementedException();
            n.read_console_thread();
        }
        
        private void add_element(object sender, EventArgs e)
        {
            create_element(12, 12, "args", 'n');
        }

        private void SizeChange(object sender, EventArgs e)
        {
            size_.W_H = (sender as Form1).Height;
            size_.W_W = (sender as Form1).Width;
            //size_._text_layer(1);
            /*panel_size_.W_H = panel1.Height;
            panel_size_.W_W = panel1.Width;
            panel_size_.Refresh();*/
            size_.Refresh();
            Refresh();
        }

        private void Created(object sender, EventArgs e)
        {            
            size_.Add(panel1 as Control, new int[]{ 10, 0, 90, 100});
            size_.Add(add_but as Control, new int[] { 0, 0, 10, 5 });
            size_.Add(build_but as Control, new int[] { 0, 5, 10, 5 });
            size_.Add(remov_but as Control, new int[] { 0, 10, 10, 5 });
            size_.Add(start_button as Control, new int[] { 0, 15, 10, 5 });
            size_.Add(textBox1 as Control, new int[] { 0, 30, 10, 5 });
            size_.Add(tcp_enable as Control, new int[] { 0, 25, 10, 5 });
            size_.Add(console_button as Control, new int[] { 0, 20, 10, 5 });
            /*Button b = new Button();
            b.Location = new Point(0, 0);
            b.Height = 20;
            b.Width = 20;
            Controls.Add(b);*/
            (sender as Form1).Refresh();
            (sender as Form1).Update();
            //size_ = new Size_(Height, Width);
            //size_.Add(b, new int[] { 0, 0, 5, 5 });
            size_.Refresh();
            Refresh();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            /*
            int i = neyrons._add<string>("", "Gonson");
            neyrons.names[i] = "Starrk Kayot";
            var stek = neyrons._get_stek(i);
            if (stek.type == 's') MessageBox.Show(stek.type.ToString());
            */
         
        }
        
        private void Update_input_data()
        {

        }

        private void build_but_Click(object sender, EventArgs e)
        {

            List<string> pattern = el.neyron_name_return();

            n.act_("buffer-", "clear_");

            foreach (string item in pattern)
                n.act_("add-", item);
            

        }
    }

    class elements_
    {

        struct element_neyron
        {
            //public int index__;
            public Panel group_box;
            public ListBox __neyros;            
            public TextBox name;
            public ComboBox neyron_next;
            //Neyron_DB neyron_s;
            
            public element_neyron(int inde_x ,int x, int y, Panel group, Neyron_DB n)
            {
                //index__ = inde_x;
                group_box = new Panel();
                __neyros = new ListBox();
                name = new TextBox();
                neyron_next = new ComboBox();
                //neyron_s = n;

                group_box.Height = 150;
                group_box.Width = 93;
                group_box.BackColor = Color.White;
                group_box.Controls.Add(__neyros);
                group_box.Controls.Add(neyron_next);
                group_box.Controls.Add(name);
                
                                
                __neyros.Width = 72;
                __neyros.Height = 70;
                __neyros.Location = new Point(10, 10);


                neyron_next.Width = 72;
                neyron_next.Height = 20;
                neyron_next.Location = new Point(10, 90);
                foreach (string item in n.names)
                    neyron_next.Items.Add(item);
                neyron_next.TextChanged += Neyron_next_TextChanged;
                neyron_next.Name = inde_x.ToString();

                name.Width = 72;
                name.Height = 20;
                name.TextChanged += Name_TextChanged;
                name.Location = new Point(10, 120);


                int index = group.Controls.Count;
                group.Controls.Add(group_box);
                group.Controls[index].Location = new Point(x, y);
            }

            private void Name_TextChanged(object sender, EventArgs e)
            {
                (sender as TextBox).Name = (sender as TextBox).Text;
            }

            private void Neyron_next_TextChanged(object sender, EventArgs e)
            {
                
            }
        }

        struct element_code
        {
            //public int index__;
            public Panel group_box;
            public ComboBox __neyros;
            //public TextBox name;
            public TextBox code;
            public ComboBox neyron_next;

            
            //Neyron_DB neyron_s;

            public element_code(int inde_x, int x, int y, Panel group, Neyron_DB n)
            {
                //index__ = inde_x;
                group_box = new Panel();
                __neyros = new ComboBox();
                //name = new TextBox();
                neyron_next = new ComboBox();
                code = new TextBox();
                //neyron_s = n;

                group_box.Height = 150;
                group_box.Width = 93;
                group_box.BackColor = Color.White;
                group_box.Controls.Add(__neyros);
                group_box.Controls.Add(neyron_next);
                //group_box.Controls.Add(name);
                group_box.Controls.Add(code);


                __neyros.Width = 72;
                __neyros.Height = 70;
                __neyros.Location = new Point(10, 10);


                neyron_next.Width = 72;
                neyron_next.Height = 20;
                neyron_next.Location = new Point(10, 90);
                foreach (string item in n.names)
                    neyron_next.Items.Add(item);
                neyron_next.TextChanged += Neyron_next_TextChanged;
                neyron_next.Name = inde_x.ToString();

                //name.Width = 72;
                //name.Height = 20;
                //name.TextChanged += Name_TextChanged;
                //name.Location = new Point(10, 120);


                int index = group.Controls.Count;
                group.Controls.Add(group_box);
                group.Controls[index].Location = new Point(x, y);
            }

            private void Name_TextChanged(object sender, EventArgs e)
            {
                (sender as TextBox).Name = (sender as TextBox).Text;
            }

            private void Neyron_next_TextChanged(object sender, EventArgs e)
            {

            }
        }

        struct element_boxing
        {
            // в байты
        }

        struct element_unboxing
        {
            // из байтов
        }

        struct element_switch
        {
            // разветвлитель
        }

        public struct normalize_
        {
            public int index_;
            public char type;
        }


        public List<normalize_> steks_;
        List<element_neyron> neyrons_;
        List<element_switch> switchs_;
        List<element_code> code_blocks_;
        List<element_boxing> boxings_;
        List<element_unboxing> unboxings_;



        public const byte NEYRON = 0;
        public const byte SWITCH = 1;
        public const byte BOX = 2;
        public const byte UNBOX = 3;
        public const byte CODE = 4;


        public List<string> neyron_name_return()
        {
            List<string> l = new List<string>();

            foreach (element_neyron item in neyrons_)
                l.Add(item.name.Text);

            return l;
        }

        public void add_element(byte type, int x, int y, Panel group, Neyron_DB n_DB)
        {
            if(type == NEYRON)
            {
                normalize_ n = new normalize_();
                n.index_ = neyrons_.Count;
                n.type = 'n';
                element_neyron el = new element_neyron(neyrons_.Count, 
                    x, y, group, n_DB);   
                           
                neyrons_.Add(el);
                steks_.Add(n);
            }
            else if(type == SWITCH)
            {
                normalize_ n = new normalize_();
                n.index_ = switchs_.Count;
                n.type = 's';
                element_switch el = new element_switch();
                switchs_.Add(el);
                steks_.Add(n);
            }
            else if(type == BOX)
            {
                normalize_ n = new normalize_();
                n.index_ = boxings_.Count;
                n.type = 'b';
                element_boxing el = new element_boxing();
                boxings_.Add(el);
                steks_.Add(n);
            }
            else if(type == UNBOX)
            {
                normalize_ n = new normalize_();
                n.index_ = unboxings_.Count;
                n.type = 'u';
                element_unboxing el = new element_unboxing();
                unboxings_.Add(el);
                steks_.Add(n);
            }
            else if(type == CODE)
            {
                normalize_ n = new normalize_();
                n.index_ = code_blocks_.Count;
                n.type = 'c';
                element_code el = new element_code();
                code_blocks_.Add(el);
                steks_.Add(n);
            }
        }

        public elements_()
        {
            steks_ = new List<normalize_>();
            neyrons_ = new List<element_neyron>();
            switchs_ = new List<element_switch>();
            code_blocks_ = new List<element_code>();
            boxings_ = new List<element_boxing>();
            unboxings_ = new List<element_unboxing>();
        }
    }

    public struct Stek { public int ID; public char type; }
    public class Branch
    {
        //public List<int> id_neyrons;//нейкон к которому обращаются
        
        public string name;

        //public bool branch_result;

        private List<string> step_name;

        //private List<int>       id_equalse_neyron;
        private List<int[]>       id_way;
        private List<int[]>     limit_value;
        private List<int[,]>    id_element;


        public string Start(List<Neyron_DB.object_s> buffer)
        {
            string arg_return = "";

            int step_by = 0;

            int step_id = id_way[step_by][0];
            int id_neyron = id_way[step_by][1];

            bool its_end = false;

            while (true)                
            {
                if(id_neyron == -1 ||
                    step_id == -1)
                {
                    its_end = true;
                    break;
                }

                int[] limits = limit_value[step_id];
                int[,] elements = id_element[step_id];

                int k = 0;
                int q = 0;

                for (int i = 0; i < limits.Length; i++)
                {
                    k = 0;
                    for (int e = 0; e < elements.Length / limits.Length; e++)
                    {
                        // + neyrons__.summ
                    }
                }
            }

            return arg_return;
        }
        

        ///// <summary>
        ///// Получаем информирующую строку
        ///// </summary>
        ///// <param name="step_id"></param>
        ///// <returns></returns>
        //public string get_information(int step_id)
        //{
        //    string arg_ret = "";
        //    arg_ret += "'" + step_name[step_id] + "': #"+id_way[step_id].ToString()+" [";

        //    for(int q = 0; q < limit_value[step_id].Count(); q++)
        //    {
        //        for(int i = 0; i < id_element[step_id].Rank; i++)
        //        {
        //            arg_ret += " "+i.ToString()+": {";
        //            for(int k = 0; k < id_element[step_id].Length/id_element[step_id].Rank; k++)
        //            {
        //                if(k == 0)
        //                {
        //                    arg_ret += " " + id_element[step_id][i, k].ToString();
        //                    continue;
        //                }
        //                arg_ret += ", "+id_element[step_id][i, k].ToString();
        //            }
        //            arg_ret += " }";
        //        } arg_ret += "<" + limit_value[step_id][q].ToString() + ">";
        //    }
        //    return arg_ret;
        //}

        /// <summary>
        /// получаем имя шага по ID
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public string get_stepName_to_ID(int id)
        {
            return step_name[id];
        }

        /// <summary>
        /// количество шагов
        /// </summary>
        /// <returns></returns>
        public int get_stepCount()
        {
            return step_name.Count;
        }

        /// <summary>
        /// Добавление шага
        /// </summary>
        /// <param name="step_name_">Имя шага</param>
        /// <param name="way_id_">ID следующего шага (если прошли лимиты)</param>
        /// <param name="limits_">Лимиты (список лимитов, которые надо пройти)</param>
        /// <param name="neyrons">Список нейронов (1 лимит - несколько нейронов)</param>
        public void Add(string step_name_, int eql_neyronID,
            int way_id_, int step_id,
            int []limits_, int[,] neyrons)
        {
            step_name.Add(step_name_);
            //id_equalse_neyron.Add(eql_neyronID);
            id_way.Add(new int[] { step_id, way_id_ });
            limit_value.Add(limits_);
            id_element.Add(neyrons);
        }

        /// <summary>
        /// ищем ID по имени шага
        /// </summary>
        /// <param name="_name"></param>
        /// <returns></returns>
        public int searchID_to_stepName(string _name)
        {
            for (int i = 0; i < step_name.Count; i++)
                if (step_name[i] == _name)
                    return i;
            return -1;
        }
        
        /// <summary>
        /// безопасное (safe) удаление по имени
        /// </summary>
        /// <param name="step_name">имя шага</param>
        public void Remove(string step_name)
        {
            int id = 0;
            if ((id = searchID_to_stepName(step_name)) != -1)
                RemoveAt(id);            
        }

        /// <summary>
        /// небезопасное (unsafe) удаление по индексу
        /// </summary>
        /// <param name="step_id"></param>
        public void RemoveAt(int step_id)
        {
            step_name.RemoveAt(step_id);
            id_element.RemoveAt(step_id);
            //id_equalse_neyron.RemoveAt(step_id);
            id_way.RemoveAt(step_id);
            limit_value.RemoveAt(step_id);
        }


        //public List<int[,,,]> idEqualseNeyron_idWay_limitValue_idElement;

        //public string limit_name;

        public Branch(string name_)
        {            
            name = name_;
            //id_equalse_neyron = new List<int>();
            id_way = new List<int[]>();
            limit_value = new List<int[]>();
            id_element = new List<int[,]>();
            step_name = new List<string>();            
        }

        
    }
    public class Neyron_DB
    {
        private List<Branch> neyro_branchs;

       

        /// <summary>
        /// переименовываем ветку и возвращаем результат операции
        /// </summary>
        /// <param name="new_name">новое имя</param>
        /// <param name="last_branch_name">старое имя</param>
        /// <returns></returns>
        public bool change_name_brench(string new_name, string last_branch_name)
        {
            for (int i = 0; i < neyro_branchs.Count; i++)
            {
                if(neyro_branchs[i].name == last_branch_name)
                {
                    neyro_branchs[i].name = new_name;
                    return true;
                }
            } return false;
        }
        
        /// <summary>
        /// возвращаем ID ветки по имени
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public int search_branchID_to_branch_name(string name)
        {
            for (int i = 0; i < neyro_branchs.Count; i++)
            {
                if (neyro_branchs[i].name == name)
                    return i;
            }
            return -1;
        }
        

        /// <summary>
        /// удаление ветки по индексу (если -1 - удаляем все ветки)
        /// </summary>
        /// <param name="ID"></param>
        public void remove_branch(int ID)
        {
            if (ID == -1)
                neyro_branchs = new List<Branch>();
            else neyro_branchs.RemoveAt(ID);
        }

        /// <summary>
        /// удаление ветки по имени
        /// </summary>
        /// <param name="name"></param>
        public void remove_branch(string name)
        {
            for (int i = 0; i < neyro_branchs.Count; i++)
                if (neyro_branchs[i].name == name)
                {
                    remove_branch(i);
                    return;
                }
        }

        /// <summary>
        /// создать ветку
        /// </summary>
        /// <returns></returns>
        public int add_branch(string name)
        {
            neyro_branchs.Add(new Branch(name));
            return neyro_branchs.Count - 1;
        }




        List<neyron_<string>> neyrn_s__string;
        private List<Stek> stek;
        public List<string> names;

        List<neyron_<int>> neyrn_s__int;
        List<neyron_<double>> neyrn_s__double;
        public void re_double_neyrs(neyron_<double> d_n, int i) { neyrn_s__double[i] = d_n; }
        public void re_int_neyrs(neyron_<int> d_n, int i) { neyrn_s__int[i] = d_n; }
        public void re_string_neyrs(neyron_<string> d_n, int i) { neyrn_s__string[i] = d_n; }
        public int __search_index_neyron(neyron_<double> n__)
        {
            for (int i = 0; i < neyrn_s__double.Count; i++)
            {
                if (n__ == neyrn_s__double[i])
                    return i;
            }
            return -1;
        }
        public int __search_index_neyron(neyron_<int> n)
        {
            for (int i = 0; i < neyrn_s__int.Count; i++)
            {
                if (n == neyrn_s__int[i])
                    return i;
            }
            return -1;
        }
        public int __search_index_neyron(neyron_<string> n)
        {
            for (int i = 0; i < neyrn_s__string.Count; i++)
            {
                if (n == neyrn_s__string[i])
                    return i;
            }
            return -1;
        }        
        public Neyron_DB()
        {
            names = new List<string>();
            neyrn_s__string = new List<neyron_<string>>();
            neyrn_s__int = new List<neyron_<int>>();
            neyrn_s__double = new List<neyron_<double>>();
            stek = new List<Stek>();
            neyro_branchs = new List<Branch>();
        }

        public struct object_s {
            public object Neyron { get; set; }
            public char type { get; set; }
            private int ID;
            public string name_neyron { get; set; }
            public int limit { get; set; }
            public object_s(object neyron, char type_, int ID_, string name_, int limit_) {
                Neyron = neyron;  type = type_; ID = ID_; name_neyron = name_; limit = limit_;
            }
            public int get_id() { return ID; }
        }
        // нейрон, тип, порядкоый номер в стеке
        public object_s create_to_name(string name, int limit_)
        {
            name = name.Trim();
            for (int i = 0; i < names.Count; i++)
            {
                if (names[i] == name)
                    if (stek[i].type == 'd')
                        return new object_s(
                            neyrn_s__double[stek[i].ID], 'd', i, name, limit_);
                    else if (stek[i].type == 'i')
                        return new object_s(
                            neyrn_s__int[stek[i].ID], 'i', i, name, limit_);
                    else if (stek[i].type == 's')
                        return new object_s(
                            neyrn_s__string[stek[i].ID],'s', i, name, limit_);
            }
            return new object_s(null, '\0', 0, null, -1);
        }

        public void __clear_stek()
        {
            stek = new List<Stek>();
        }

        public int remove_neyron(string name)
        {
            for (int i = 0; i < names.Count; i++)
            {
                if (names[i] == name)
                {
                    if (stek[i].type == 'd')
                    { neyrn_s__double.RemoveAt(stek[i].ID); stek.RemoveAt(i); }
                    else if (stek[i].type == 'i')
                    { neyrn_s__int.RemoveAt(stek[i].ID); stek.RemoveAt(i); }
                    else if (stek[i].type == 's')
                    { neyrn_s__string.RemoveAt(stek[i].ID); stek.RemoveAt(i); }
                    names.RemoveAt(i);
                    return i;
                }
            }
            return -1;
        }

        public int _add<T>(T neyron, string name)
        {
            if (neyron.GetType() == typeof(double))
            {
                Stek s = new Stek();
                s.ID = neyrn_s__double.Count();
                s.type = 'd';
                stek.Add(s);
                neyrn_s__double.Add(new neyron_<double>(3.14));
            }
            else if (neyron.GetType() == typeof(int))
            {
                Stek s = new Stek();
                s.ID = neyrn_s__int.Count();
                s.type = 'i';
                stek.Add(s);
                neyrn_s__int.Add(new neyron_<int>(0));
            } else             
            {                
                Stek s = new Stek();
                s.ID = neyrn_s__string.Count();
                s.type = 's';
                stek.Add(s);
                neyrn_s__string.Add(new neyron_<string>(""));
            }
            names.Add(name);
            return stek.Count - 1;
        }

        public int _add<T>(T neyron)
        {
            if (neyron.GetType() == typeof(double))
            {
                Stek s = new Stek();
                s.ID = neyrn_s__double.Count();
                s.type = 'd';
                stek.Add(s);
                neyrn_s__double.Add(new neyron_<double>(3.14));
            }
            else if (neyron.GetType() == typeof(int))
            {
                Stek s = new Stek();
                s.ID = neyrn_s__int.Count();
                s.type = 'i';
                stek.Add(s);
                neyrn_s__int.Add(new neyron_<int>(0));
            }
            else
            {                
                Stek s = new Stek();
                s.ID = neyrn_s__string.Count();
                s.type = 's';
                stek.Add(s);
                neyrn_s__string.Add(new neyron_<string>(""));
            }
            names.Add((stek.Count - 1).ToString());
            return stek.Count - 1;
        }
        public Stek _get_stek(int index)
        {
            return stek[index];
        }
        public neyron_<string> _get_string_neyron(int index)
        {
            return neyrn_s__string[index];
        }
        public neyron_<int> _get_int_neyron(int index)
        {
            return neyrn_s__int[index];
        }
        public neyron_<double> _get_double_neyron(int index)
        {
            return neyrn_s__double[index];
        }                        
    }
    class Size_        
    {        
        public List<Control> Controls_ { get; set; }
        public List<int[]> Controls_procent { get; set; }
        // position x, position y, width, heihgt
        public int W_H { get; set; }
        public int W_W { get; set; }

        public Size_(int Windows_H, int Windows_W)
        {
            W_H = Windows_H;
            W_W = Windows_W;
            Controls_ = new List<Control>();
            Controls_procent = new List<int[]>();
        }
        
        public void Refresh()
        {
            
            double one_percent_position_x = Convert.ToDouble(W_W) / 100;
            double one_percent_position_y = Convert.ToDouble(W_H) / 100;

            for (int i = 0; i < Controls_.Count; i++)
            {
                Controls_[i].Location = new Point(
                    Convert.ToInt32(Math.Round(one_percent_position_x * Controls_procent[i]
                    [0])), 
                    Convert.ToInt32(Math.Round(one_percent_position_y * Controls_procent[i]
                    [1])));
                Controls_[i].Width = Convert.ToInt32(
                    Math.Round(one_percent_position_x *
                    Controls_procent[i][2]));
                Controls_[i].Height = Convert.ToInt32(
                    Math.Round(one_percent_position_y *
                    Controls_procent[i][3]));
            }            
        }

        /*
                1 пункт (компьютерный) = 1.333333333333 пиксель (Y)
                2 пункт (компьютерный) = 2.666666666667 пиксель (Y)
                3 пункт (компьютерный) = 4 пиксель (Y)
-------------------------------------------------------------------------------
                1 пиксель (X) = 0.75 пункт (компьютерный)
                2 пиксель (X) = 1.5 пункт (компьютерный)
                3 пиксель (X) = 2.25 пункт (компьютерный)
                4 пиксель (X) = 3 пункт (компьютерный)
                5 пиксель (X) = 3.75 пункт (компьютерный)
                6 пиксель (X) = 4.5 пункт (компьютерный)
                7 пиксель (X) = 5.25 пункт (компьютерный)
                8 пиксель (X) = 6 пункт (компьютерный)
                9 пиксель (X) = 6.75 пункт (компьютерный)
                10 пиксель (X) = 7.5 пункт (компьютерный)
------------------------------------------------------------------------------

         */
         /*
        public void _text_layer(int index)
        {
            if( Controls_[index].Height > Controls_[index].Width)
            Controls_[index].Font = new Font(FontFamily.GenericSansSerif, Controls_[index].Height-40 * (float)0.75, FontStyle.Regular);
            else Controls_[index].Font = new Font(FontFamily.GenericSansSerif, Controls_[index].Width-40 * (float)0.75, FontStyle.Regular);

        }
        */

        public void Add(Control c, int[] procent)
        {
            Controls_.Add(c);
            Controls_procent.Add(procent);
        }
        public void Remove_At(int index)
        {
            Controls_.RemoveAt(index);
            Controls_procent.RemoveAt(index);
        }
    }

}
