namespace OrderCreator
{
    partial class OrderCreator
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.firstName = new System.Windows.Forms.TextBox();
            this.lastName = new System.Windows.Forms.TextBox();
            this.dateOfBirth = new System.Windows.Forms.TextBox();
            this.labelFirstName = new System.Windows.Forms.Label();
            this.labelLastName = new System.Windows.Forms.Label();
            this.labelDateOfBirth = new System.Windows.Forms.Label();
            this.groupBoxProduct = new System.Windows.Forms.GroupBox();
            this.productName = new System.Windows.Forms.TextBox();
            this.productQuantity = new System.Windows.Forms.TextBox();
            this.productPrice = new System.Windows.Forms.TextBox();
            this.labelProductName = new System.Windows.Forms.Label();
            this.labelProductQuantity = new System.Windows.Forms.Label();
            this.labelProductPrice = new System.Windows.Forms.Label();
            this.groupBoxUser = new System.Windows.Forms.GroupBox();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.labelProductList = new System.Windows.Forms.Label();
            this.buttonSaveDataToDatabase = new System.Windows.Forms.Button();
            this.buttonSaveToXML = new System.Windows.Forms.Button();
            this.groupBoxProduct.SuspendLayout();
            this.groupBoxUser.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // firstName
            // 
            this.firstName.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.firstName.Location = new System.Drawing.Point(122, 30);
            this.firstName.Name = "firstName";
            this.firstName.Size = new System.Drawing.Size(203, 27);
            this.firstName.TabIndex = 0;
            // 
            // lastName
            // 
            this.lastName.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lastName.Location = new System.Drawing.Point(122, 71);
            this.lastName.Name = "lastName";
            this.lastName.Size = new System.Drawing.Size(203, 27);
            this.lastName.TabIndex = 1;
            // 
            // dateOfBirth
            // 
            this.dateOfBirth.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dateOfBirth.Location = new System.Drawing.Point(123, 119);
            this.dateOfBirth.Name = "dateOfBirth";
            this.dateOfBirth.Size = new System.Drawing.Size(203, 27);
            this.dateOfBirth.TabIndex = 2;
            // 
            // labelFirstName
            // 
            this.labelFirstName.AutoSize = true;
            this.labelFirstName.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelFirstName.Location = new System.Drawing.Point(6, 33);
            this.labelFirstName.Name = "labelFirstName";
            this.labelFirstName.Size = new System.Drawing.Size(38, 20);
            this.labelFirstName.TabIndex = 3;
            this.labelFirstName.Text = "Imię";
            // 
            // labelLastName
            // 
            this.labelLastName.AutoSize = true;
            this.labelLastName.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelLastName.Location = new System.Drawing.Point(6, 74);
            this.labelLastName.Name = "labelLastName";
            this.labelLastName.Size = new System.Drawing.Size(72, 20);
            this.labelLastName.TabIndex = 4;
            this.labelLastName.Text = "Nazwisko";
            // 
            // labelDateOfBirth
            // 
            this.labelDateOfBirth.AutoSize = true;
            this.labelDateOfBirth.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelDateOfBirth.Location = new System.Drawing.Point(6, 122);
            this.labelDateOfBirth.Name = "labelDateOfBirth";
            this.labelDateOfBirth.Size = new System.Drawing.Size(111, 20);
            this.labelDateOfBirth.TabIndex = 5;
            this.labelDateOfBirth.Text = "Data urodzenia";
            // 
            // groupBoxProduct
            // 
            this.groupBoxProduct.Controls.Add(this.buttonUpdate);
            this.groupBoxProduct.Controls.Add(this.buttonDelete);
            this.groupBoxProduct.Controls.Add(this.buttonAdd);
            this.groupBoxProduct.Controls.Add(this.labelProductPrice);
            this.groupBoxProduct.Controls.Add(this.labelProductQuantity);
            this.groupBoxProduct.Controls.Add(this.labelProductName);
            this.groupBoxProduct.Controls.Add(this.productPrice);
            this.groupBoxProduct.Controls.Add(this.productQuantity);
            this.groupBoxProduct.Controls.Add(this.productName);
            this.groupBoxProduct.Location = new System.Drawing.Point(377, 12);
            this.groupBoxProduct.Name = "groupBoxProduct";
            this.groupBoxProduct.Size = new System.Drawing.Size(411, 170);
            this.groupBoxProduct.TabIndex = 6;
            this.groupBoxProduct.TabStop = false;
            this.groupBoxProduct.Text = "Produkt";
            // 
            // productName
            // 
            this.productName.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.productName.Location = new System.Drawing.Point(75, 30);
            this.productName.Name = "productName";
            this.productName.Size = new System.Drawing.Size(311, 27);
            this.productName.TabIndex = 1;
            // 
            // productQuantity
            // 
            this.productQuantity.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.productQuantity.Location = new System.Drawing.Point(75, 68);
            this.productQuantity.Name = "productQuantity";
            this.productQuantity.Size = new System.Drawing.Size(122, 27);
            this.productQuantity.TabIndex = 2;
            // 
            // productPrice
            // 
            this.productPrice.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.productPrice.Location = new System.Drawing.Point(261, 67);
            this.productPrice.Name = "productPrice";
            this.productPrice.Size = new System.Drawing.Size(125, 27);
            this.productPrice.TabIndex = 3;
            // 
            // labelProductName
            // 
            this.labelProductName.AutoSize = true;
            this.labelProductName.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelProductName.Location = new System.Drawing.Point(15, 33);
            this.labelProductName.Name = "labelProductName";
            this.labelProductName.Size = new System.Drawing.Size(54, 20);
            this.labelProductName.TabIndex = 4;
            this.labelProductName.Text = "Nazwa";
            // 
            // labelProductQuantity
            // 
            this.labelProductQuantity.AutoSize = true;
            this.labelProductQuantity.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelProductQuantity.Location = new System.Drawing.Point(15, 71);
            this.labelProductQuantity.Name = "labelProductQuantity";
            this.labelProductQuantity.Size = new System.Drawing.Size(39, 20);
            this.labelProductQuantity.TabIndex = 5;
            this.labelProductQuantity.Text = "Ilość";
            // 
            // labelProductPrice
            // 
            this.labelProductPrice.AutoSize = true;
            this.labelProductPrice.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelProductPrice.Location = new System.Drawing.Point(213, 70);
            this.labelProductPrice.Name = "labelProductPrice";
            this.labelProductPrice.Size = new System.Drawing.Size(42, 20);
            this.labelProductPrice.TabIndex = 6;
            this.labelProductPrice.Text = "Cena";
            // 
            // groupBoxUser
            // 
            this.groupBoxUser.Controls.Add(this.labelDateOfBirth);
            this.groupBoxUser.Controls.Add(this.labelLastName);
            this.groupBoxUser.Controls.Add(this.firstName);
            this.groupBoxUser.Controls.Add(this.lastName);
            this.groupBoxUser.Controls.Add(this.dateOfBirth);
            this.groupBoxUser.Controls.Add(this.labelFirstName);
            this.groupBoxUser.Location = new System.Drawing.Point(12, 12);
            this.groupBoxUser.Name = "groupBoxUser";
            this.groupBoxUser.Size = new System.Drawing.Size(348, 170);
            this.groupBoxUser.TabIndex = 7;
            this.groupBoxUser.TabStop = false;
            this.groupBoxUser.Text = "Zamawiający";
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(19, 122);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(100, 30);
            this.buttonAdd.TabIndex = 7;
            this.buttonAdd.Text = "Dodaj";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(155, 122);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(100, 30);
            this.buttonDelete.TabIndex = 8;
            this.buttonDelete.Text = "Usuń";
            this.buttonDelete.UseVisualStyleBackColor = true;
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Location = new System.Drawing.Point(286, 122);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(100, 30);
            this.buttonUpdate.TabIndex = 9;
            this.buttonUpdate.Text = "Zmień";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridProductName,
            this.dataGridQuantity,
            this.dataGridPrice});
            this.dataGridView.Location = new System.Drawing.Point(12, 217);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowHeadersWidth = 30;
            this.dataGridView.RowTemplate.Height = 30;
            this.dataGridView.Size = new System.Drawing.Size(633, 183);
            this.dataGridView.TabIndex = 8;
            // 
            // dataGridProductName
            // 
            this.dataGridProductName.HeaderText = "Nazwa Produktu";
            this.dataGridProductName.MinimumWidth = 100;
            this.dataGridProductName.Name = "dataGridProductName";
            this.dataGridProductName.Width = 400;
            // 
            // dataGridQuantity
            // 
            this.dataGridQuantity.HeaderText = "Ilość";
            this.dataGridQuantity.Name = "dataGridQuantity";
            // 
            // dataGridPrice
            // 
            this.dataGridPrice.HeaderText = "Cena";
            this.dataGridPrice.Name = "dataGridPrice";
            // 
            // labelProductList
            // 
            this.labelProductList.AutoSize = true;
            this.labelProductList.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelProductList.Location = new System.Drawing.Point(12, 194);
            this.labelProductList.Name = "labelProductList";
            this.labelProductList.Size = new System.Drawing.Size(151, 20);
            this.labelProductList.TabIndex = 9;
            this.labelProductList.Text = "Zamówione produkty";
            // 
            // buttonSaveDataToDatabase
            // 
            this.buttonSaveDataToDatabase.Location = new System.Drawing.Point(663, 237);
            this.buttonSaveDataToDatabase.Name = "buttonSaveDataToDatabase";
            this.buttonSaveDataToDatabase.Size = new System.Drawing.Size(114, 56);
            this.buttonSaveDataToDatabase.TabIndex = 10;
            this.buttonSaveDataToDatabase.Text = "Zapisz do bazy danych";
            this.buttonSaveDataToDatabase.UseVisualStyleBackColor = true;
            // 
            // buttonSaveToXML
            // 
            this.buttonSaveToXML.Location = new System.Drawing.Point(663, 325);
            this.buttonSaveToXML.Name = "buttonSaveToXML";
            this.buttonSaveToXML.Size = new System.Drawing.Size(114, 56);
            this.buttonSaveToXML.TabIndex = 11;
            this.buttonSaveToXML.Text = "Zapisz do XML";
            this.buttonSaveToXML.UseVisualStyleBackColor = true;
            this.buttonSaveToXML.Click += new System.EventHandler(this.buttonSaveToXML_Click);
            // 
            // OrderCreator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 412);
            this.Controls.Add(this.buttonSaveToXML);
            this.Controls.Add(this.buttonSaveDataToDatabase);
            this.Controls.Add(this.labelProductList);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.groupBoxUser);
            this.Controls.Add(this.groupBoxProduct);
            this.Name = "OrderCreator";
            this.Text = "OrderCreator";
            this.groupBoxProduct.ResumeLayout(false);
            this.groupBoxProduct.PerformLayout();
            this.groupBoxUser.ResumeLayout(false);
            this.groupBoxUser.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox firstName;
        private System.Windows.Forms.TextBox lastName;
        private System.Windows.Forms.TextBox dateOfBirth;
        private System.Windows.Forms.Label labelFirstName;
        private System.Windows.Forms.Label labelLastName;
        private System.Windows.Forms.Label labelDateOfBirth;
        private System.Windows.Forms.GroupBox groupBoxProduct;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Label labelProductPrice;
        private System.Windows.Forms.Label labelProductQuantity;
        private System.Windows.Forms.Label labelProductName;
        private System.Windows.Forms.TextBox productPrice;
        private System.Windows.Forms.TextBox productQuantity;
        private System.Windows.Forms.TextBox productName;
        private System.Windows.Forms.GroupBox groupBoxUser;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridProductName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridPrice;
        private System.Windows.Forms.Label labelProductList;
        private System.Windows.Forms.Button buttonSaveDataToDatabase;
        private System.Windows.Forms.Button buttonSaveToXML;
    }
}

