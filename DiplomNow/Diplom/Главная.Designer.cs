namespace Diplom
{
    partial class Главная
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.учетToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.регистрыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.регистрХПНToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.регистрБАИХОБЛToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.регистрССЗToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.аналитикаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.нозологическиеРегистрыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.данныеПоРегиструХПНToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.данныеПоРегструОКСToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.данныеПоРегиструБАИХОБЛToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.данныеПоРегиструССЗToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.настройкиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.настройкиДиспансерногоНаблюденияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.нозологическиеРегистрыToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.hpnDataSet = new Diplom.hpnDataSet111();
            this.agentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.agentTableAdapter = new Diplom.hpnDataSetTableAdapters.agentTableAdapter();
            this.регистратураToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сервисToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.рабочееМестоToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.учетБеременныхToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.учетМедикаментовToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hpnDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.agentBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.регистратураToolStripMenuItem,
            this.рабочееМестоToolStripMenuItem,
            this.учетToolStripMenuItem,
            this.аналитикаToolStripMenuItem,
            this.настройкиToolStripMenuItem,
            this.сервисToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1006, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // учетToolStripMenuItem
            // 
            this.учетToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.регистрыToolStripMenuItem,
            this.учетБеременныхToolStripMenuItem,
            this.учетМедикаментовToolStripMenuItem});
            this.учетToolStripMenuItem.Name = "учетToolStripMenuItem";
            this.учетToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.учетToolStripMenuItem.Text = "Учет";
            // 
            // регистрыToolStripMenuItem
            // 
            this.регистрыToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.регистрХПНToolStripMenuItem,
            this.регистрБАИХОБЛToolStripMenuItem,
            this.регистрССЗToolStripMenuItem});
            this.регистрыToolStripMenuItem.Name = "регистрыToolStripMenuItem";
            this.регистрыToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.регистрыToolStripMenuItem.Text = "Регистры";
            // 
            // регистрХПНToolStripMenuItem
            // 
            this.регистрХПНToolStripMenuItem.Name = "регистрХПНToolStripMenuItem";
            this.регистрХПНToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.регистрХПНToolStripMenuItem.Text = "Регистр ХПН";
            this.регистрХПНToolStripMenuItem.Click += new System.EventHandler(this.регистрХПНToolStripMenuItem_Click);
            // 
            // регистрБАИХОБЛToolStripMenuItem
            // 
            this.регистрБАИХОБЛToolStripMenuItem.Name = "регистрБАИХОБЛToolStripMenuItem";
            this.регистрБАИХОБЛToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.регистрБАИХОБЛToolStripMenuItem.Text = "Регистр БА и ХОБЛ";
            this.регистрБАИХОБЛToolStripMenuItem.Click += new System.EventHandler(this.регистрБАИХОБЛToolStripMenuItem_Click);
            // 
            // регистрССЗToolStripMenuItem
            // 
            this.регистрССЗToolStripMenuItem.Name = "регистрССЗToolStripMenuItem";
            this.регистрССЗToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.регистрССЗToolStripMenuItem.Text = "Регистр ССЗ";
            this.регистрССЗToolStripMenuItem.Click += new System.EventHandler(this.регистрССЗToolStripMenuItem_Click);
            // 
            // аналитикаToolStripMenuItem
            // 
            this.аналитикаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.нозологическиеРегистрыToolStripMenuItem});
            this.аналитикаToolStripMenuItem.Name = "аналитикаToolStripMenuItem";
            this.аналитикаToolStripMenuItem.Size = new System.Drawing.Size(78, 20);
            this.аналитикаToolStripMenuItem.Text = "Аналитика";
            // 
            // нозологическиеРегистрыToolStripMenuItem
            // 
            this.нозологическиеРегистрыToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.данныеПоРегиструХПНToolStripMenuItem,
            this.данныеПоРегструОКСToolStripMenuItem,
            this.данныеПоРегиструБАИХОБЛToolStripMenuItem,
            this.данныеПоРегиструССЗToolStripMenuItem});
            this.нозологическиеРегистрыToolStripMenuItem.Name = "нозологическиеРегистрыToolStripMenuItem";
            this.нозологическиеРегистрыToolStripMenuItem.Size = new System.Drawing.Size(221, 22);
            this.нозологическиеРегистрыToolStripMenuItem.Text = "Нозологические регистры";
            // 
            // данныеПоРегиструХПНToolStripMenuItem
            // 
            this.данныеПоРегиструХПНToolStripMenuItem.Name = "данныеПоРегиструХПНToolStripMenuItem";
            this.данныеПоРегиструХПНToolStripMenuItem.Size = new System.Drawing.Size(248, 22);
            this.данныеПоРегиструХПНToolStripMenuItem.Text = "Данные по регистру ХПН";
            // 
            // данныеПоРегструОКСToolStripMenuItem
            // 
            this.данныеПоРегструОКСToolStripMenuItem.Name = "данныеПоРегструОКСToolStripMenuItem";
            this.данныеПоРегструОКСToolStripMenuItem.Size = new System.Drawing.Size(248, 22);
            this.данныеПоРегструОКСToolStripMenuItem.Text = "Данные по регистру ОКС";
            this.данныеПоРегструОКСToolStripMenuItem.Click += new System.EventHandler(this.данныеПоРегструОКСToolStripMenuItem_Click);
            // 
            // данныеПоРегиструБАИХОБЛToolStripMenuItem
            // 
            this.данныеПоРегиструБАИХОБЛToolStripMenuItem.Name = "данныеПоРегиструБАИХОБЛToolStripMenuItem";
            this.данныеПоРегиструБАИХОБЛToolStripMenuItem.Size = new System.Drawing.Size(248, 22);
            this.данныеПоРегиструБАИХОБЛToolStripMenuItem.Text = "Данные по регистру БА и ХОБЛ";
            // 
            // данныеПоРегиструССЗToolStripMenuItem
            // 
            this.данныеПоРегиструССЗToolStripMenuItem.Name = "данныеПоРегиструССЗToolStripMenuItem";
            this.данныеПоРегиструССЗToolStripMenuItem.Size = new System.Drawing.Size(248, 22);
            this.данныеПоРегиструССЗToolStripMenuItem.Text = "Данные по регистру ССЗ";
            // 
            // настройкиToolStripMenuItem
            // 
            this.настройкиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.настройкиДиспансерногоНаблюденияToolStripMenuItem});
            this.настройкиToolStripMenuItem.Name = "настройкиToolStripMenuItem";
            this.настройкиToolStripMenuItem.Size = new System.Drawing.Size(79, 20);
            this.настройкиToolStripMenuItem.Text = "Настройки";
            // 
            // настройкиДиспансерногоНаблюденияToolStripMenuItem
            // 
            this.настройкиДиспансерногоНаблюденияToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.нозологическиеРегистрыToolStripMenuItem1});
            this.настройкиДиспансерногоНаблюденияToolStripMenuItem.Name = "настройкиДиспансерногоНаблюденияToolStripMenuItem";
            this.настройкиДиспансерногоНаблюденияToolStripMenuItem.Size = new System.Drawing.Size(293, 22);
            this.настройкиДиспансерногоНаблюденияToolStripMenuItem.Text = "Настройки диспансерного наблюдения";
            // 
            // нозологическиеРегистрыToolStripMenuItem1
            // 
            this.нозологическиеРегистрыToolStripMenuItem1.Name = "нозологическиеРегистрыToolStripMenuItem1";
            this.нозологическиеРегистрыToolStripMenuItem1.Size = new System.Drawing.Size(221, 22);
            this.нозологическиеРегистрыToolStripMenuItem1.Text = "Нозологические регистры";
            // 
            // hpnDataSet
            // 
            this.hpnDataSet.DataSetName = "hpnDataSet";
            this.hpnDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // agentBindingSource
            // 
            this.agentBindingSource.DataMember = "agent";
            this.agentBindingSource.DataSource = this.hpnDataSet;
            // 
            // agentTableAdapter
            // 
            this.agentTableAdapter.ClearBeforeFill = true;
            // 
            // регистратураToolStripMenuItem
            // 
            this.регистратураToolStripMenuItem.Name = "регистратураToolStripMenuItem";
            this.регистратураToolStripMenuItem.Size = new System.Drawing.Size(92, 20);
            this.регистратураToolStripMenuItem.Text = "Регистратура";
            // 
            // сервисToolStripMenuItem
            // 
            this.сервисToolStripMenuItem.Name = "сервисToolStripMenuItem";
            this.сервисToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.сервисToolStripMenuItem.Text = "Сервис";
            // 
            // рабочееМестоToolStripMenuItem
            // 
            this.рабочееМестоToolStripMenuItem.Name = "рабочееМестоToolStripMenuItem";
            this.рабочееМестоToolStripMenuItem.Size = new System.Drawing.Size(101, 20);
            this.рабочееМестоToolStripMenuItem.Text = "Рабочее место";
            // 
            // учетБеременныхToolStripMenuItem
            // 
            this.учетБеременныхToolStripMenuItem.Name = "учетБеременныхToolStripMenuItem";
            this.учетБеременныхToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.учетБеременныхToolStripMenuItem.Text = "Учет беременных";
            // 
            // учетМедикаментовToolStripMenuItem
            // 
            this.учетМедикаментовToolStripMenuItem.Name = "учетМедикаментовToolStripMenuItem";
            this.учетМедикаментовToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.учетМедикаментовToolStripMenuItem.Text = "Учет медикаментов";
            // 
            // Главная
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Diplom.Properties.Resources.fon;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1006, 412);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Главная";
            this.Text = "Демонстрация возможностей регистра ХПН";
            this.Activated += new System.EventHandler(this.Главная_Activated);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hpnDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.agentBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private hpnDataSet111 hpnDataSet;
        private System.Windows.Forms.BindingSource agentBindingSource;
        private hpnDataSetTableAdapters.agentTableAdapter agentTableAdapter;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem учетToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem регистрыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem регистрХПНToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem регистрБАИХОБЛToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem регистрССЗToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem аналитикаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem нозологическиеРегистрыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem данныеПоРегиструХПНToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem данныеПоРегструОКСToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem данныеПоРегиструБАИХОБЛToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem данныеПоРегиструССЗToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem настройкиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem настройкиДиспансерногоНаблюденияToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem нозологическиеРегистрыToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem регистратураToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem рабочееМестоToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem учетБеременныхToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem учетМедикаментовToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сервисToolStripMenuItem;
     

    }
}

