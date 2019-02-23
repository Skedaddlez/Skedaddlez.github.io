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

namespace AutoBlogPoster
{
    public partial class AutoBlogPoster : Form
    {
        public string blogtitle;
        public string blogtext;
        public string imagelocation;
        public string imagename;
        public AutoBlogPoster()
        {
            InitializeComponent();
            
        }

        

        private void button1_Click(object sender, EventArgs e)
        {            
            DialogResult result = openFileDialog1.ShowDialog(); // Show the dialog.
            if (result == DialogResult.OK) // Test result.
            {
                string file = openFileDialog1.FileName;
                MessageBox.Show(file);
                pictureBox1.ImageLocation = file;
                imagelocation = file;
                imagename = openFileDialog1.SafeFileName;
            }            
            Console.WriteLine(result); // <-- For debugging use.
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DateTime blogdate = DateTime.Today;
            string date = blogdate.ToString("dd/MM/yyyy");
            string Fheading = heading.Text;
            string Ftext = textarea.Text;

            //Copy photo
            string newimgpath = "D:/Documents/GitHub/Skedaddlez.github.io/images/blogposts/" + imagename;
            try
            {
                File.Copy(imagelocation, newimgpath);
            }
            catch{

            }
            string newimgpathread = "images/blogposts/" + imagename;

            //Injection into template
            const string format = "BlogTemp.txt";
            var content = System.IO.File.ReadAllText(format);
            content = content.Replace("{Heading}", Fheading);
            content = content.Replace("{date}", date);
            content = content.Replace("{TextArea}", Ftext);
            content = content.Replace("{imagelocation}", newimgpathread);            

            //Injection into blog
            const string blograw = "D:/Documents/GitHub/Skedaddlez.github.io/Blog.html";
            var blogcontent = System.IO.File.ReadAllText(blograw);
            blogcontent = blogcontent.Replace("<!-- PH -->", content);
            System.IO.File.WriteAllText("D:/Documents/GitHub/Skedaddlez.github.io/Blog.html", blogcontent);
        }
    }
}
