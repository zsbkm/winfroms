namespace Coaches
{
    partial class FormDNNUsers
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            dataGridView1 = new DataGridView();
            userIdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            usernameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            firstNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            lastNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            isSuperUserDataGridViewCheckBoxColumn = new DataGridViewCheckBoxColumn();
            affiliateIdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            emailDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            displayNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            updatePasswordDataGridViewCheckBoxColumn = new DataGridViewCheckBoxColumn();
            lastIpaddressDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            isDeletedDataGridViewCheckBoxColumn = new DataGridViewCheckBoxColumn();
            createdByUserIdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            createdOnDateDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            lastModifiedByUserIdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            lastModifiedOnDateDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            passwordResetTokenDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            passwordResetExpirationDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            contentWorkflowStatePermissionDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            coreMessagingSubscriptionsDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            desktopModulePermissionDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            folderPermissionDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            modulePermissionDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            passwordHistoryDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            personaBarMenuPermissionDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            portalPermissionDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            profileDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            relationshipsDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            tabPermissionDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            userAuthenticationDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            userPortalsDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            userProfileDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            userRelationshipPreferencesDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            userRelationshipsRelatedUserDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            userRelationshipsUserDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            userRolesDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            usersOnlineDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            usersBindingSource = new BindingSource(components);
            button1 = new Button();
            textBoxEdzoSzuro = new TextBox();
            label1 = new Label();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)usersBindingSource).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { userIdDataGridViewTextBoxColumn, usernameDataGridViewTextBoxColumn, firstNameDataGridViewTextBoxColumn, lastNameDataGridViewTextBoxColumn, isSuperUserDataGridViewCheckBoxColumn, affiliateIdDataGridViewTextBoxColumn, emailDataGridViewTextBoxColumn, displayNameDataGridViewTextBoxColumn, updatePasswordDataGridViewCheckBoxColumn, lastIpaddressDataGridViewTextBoxColumn, isDeletedDataGridViewCheckBoxColumn, createdByUserIdDataGridViewTextBoxColumn, createdOnDateDataGridViewTextBoxColumn, lastModifiedByUserIdDataGridViewTextBoxColumn, lastModifiedOnDateDataGridViewTextBoxColumn, passwordResetTokenDataGridViewTextBoxColumn, passwordResetExpirationDataGridViewTextBoxColumn, contentWorkflowStatePermissionDataGridViewTextBoxColumn, coreMessagingSubscriptionsDataGridViewTextBoxColumn, desktopModulePermissionDataGridViewTextBoxColumn, folderPermissionDataGridViewTextBoxColumn, modulePermissionDataGridViewTextBoxColumn, passwordHistoryDataGridViewTextBoxColumn, personaBarMenuPermissionDataGridViewTextBoxColumn, portalPermissionDataGridViewTextBoxColumn, profileDataGridViewTextBoxColumn, relationshipsDataGridViewTextBoxColumn, tabPermissionDataGridViewTextBoxColumn, userAuthenticationDataGridViewTextBoxColumn, userPortalsDataGridViewTextBoxColumn, userProfileDataGridViewTextBoxColumn, userRelationshipPreferencesDataGridViewTextBoxColumn, userRelationshipsRelatedUserDataGridViewTextBoxColumn, userRelationshipsUserDataGridViewTextBoxColumn, userRolesDataGridViewTextBoxColumn, usersOnlineDataGridViewTextBoxColumn });
            dataGridView1.DataSource = usersBindingSource;
            dataGridView1.Location = new Point(12, 65);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(339, 254);
            dataGridView1.TabIndex = 0;
            // 
            // userIdDataGridViewTextBoxColumn
            // 
            userIdDataGridViewTextBoxColumn.DataPropertyName = "UserId";
            userIdDataGridViewTextBoxColumn.HeaderText = "UserId";
            userIdDataGridViewTextBoxColumn.Name = "userIdDataGridViewTextBoxColumn";
            userIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // usernameDataGridViewTextBoxColumn
            // 
            usernameDataGridViewTextBoxColumn.DataPropertyName = "Username";
            usernameDataGridViewTextBoxColumn.HeaderText = "Username";
            usernameDataGridViewTextBoxColumn.Name = "usernameDataGridViewTextBoxColumn";
            usernameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // firstNameDataGridViewTextBoxColumn
            // 
            firstNameDataGridViewTextBoxColumn.DataPropertyName = "FirstName";
            firstNameDataGridViewTextBoxColumn.HeaderText = "FirstName";
            firstNameDataGridViewTextBoxColumn.Name = "firstNameDataGridViewTextBoxColumn";
            firstNameDataGridViewTextBoxColumn.ReadOnly = true;
            firstNameDataGridViewTextBoxColumn.Visible = false;
            // 
            // lastNameDataGridViewTextBoxColumn
            // 
            lastNameDataGridViewTextBoxColumn.DataPropertyName = "LastName";
            lastNameDataGridViewTextBoxColumn.HeaderText = "LastName";
            lastNameDataGridViewTextBoxColumn.Name = "lastNameDataGridViewTextBoxColumn";
            lastNameDataGridViewTextBoxColumn.ReadOnly = true;
            lastNameDataGridViewTextBoxColumn.Visible = false;
            // 
            // isSuperUserDataGridViewCheckBoxColumn
            // 
            isSuperUserDataGridViewCheckBoxColumn.DataPropertyName = "IsSuperUser";
            isSuperUserDataGridViewCheckBoxColumn.HeaderText = "IsSuperUser";
            isSuperUserDataGridViewCheckBoxColumn.Name = "isSuperUserDataGridViewCheckBoxColumn";
            isSuperUserDataGridViewCheckBoxColumn.ReadOnly = true;
            isSuperUserDataGridViewCheckBoxColumn.Visible = false;
            // 
            // affiliateIdDataGridViewTextBoxColumn
            // 
            affiliateIdDataGridViewTextBoxColumn.DataPropertyName = "AffiliateId";
            affiliateIdDataGridViewTextBoxColumn.HeaderText = "AffiliateId";
            affiliateIdDataGridViewTextBoxColumn.Name = "affiliateIdDataGridViewTextBoxColumn";
            affiliateIdDataGridViewTextBoxColumn.ReadOnly = true;
            affiliateIdDataGridViewTextBoxColumn.Visible = false;
            // 
            // emailDataGridViewTextBoxColumn
            // 
            emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            emailDataGridViewTextBoxColumn.HeaderText = "Email";
            emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            emailDataGridViewTextBoxColumn.ReadOnly = true;
            emailDataGridViewTextBoxColumn.Visible = false;
            // 
            // displayNameDataGridViewTextBoxColumn
            // 
            displayNameDataGridViewTextBoxColumn.DataPropertyName = "DisplayName";
            displayNameDataGridViewTextBoxColumn.HeaderText = "DisplayName";
            displayNameDataGridViewTextBoxColumn.Name = "displayNameDataGridViewTextBoxColumn";
            displayNameDataGridViewTextBoxColumn.ReadOnly = true;
            displayNameDataGridViewTextBoxColumn.Visible = false;
            // 
            // updatePasswordDataGridViewCheckBoxColumn
            // 
            updatePasswordDataGridViewCheckBoxColumn.DataPropertyName = "UpdatePassword";
            updatePasswordDataGridViewCheckBoxColumn.HeaderText = "UpdatePassword";
            updatePasswordDataGridViewCheckBoxColumn.Name = "updatePasswordDataGridViewCheckBoxColumn";
            updatePasswordDataGridViewCheckBoxColumn.ReadOnly = true;
            updatePasswordDataGridViewCheckBoxColumn.Visible = false;
            // 
            // lastIpaddressDataGridViewTextBoxColumn
            // 
            lastIpaddressDataGridViewTextBoxColumn.DataPropertyName = "LastIpaddress";
            lastIpaddressDataGridViewTextBoxColumn.HeaderText = "LastIpaddress";
            lastIpaddressDataGridViewTextBoxColumn.Name = "lastIpaddressDataGridViewTextBoxColumn";
            lastIpaddressDataGridViewTextBoxColumn.ReadOnly = true;
            lastIpaddressDataGridViewTextBoxColumn.Visible = false;
            // 
            // isDeletedDataGridViewCheckBoxColumn
            // 
            isDeletedDataGridViewCheckBoxColumn.DataPropertyName = "IsDeleted";
            isDeletedDataGridViewCheckBoxColumn.HeaderText = "IsDeleted";
            isDeletedDataGridViewCheckBoxColumn.Name = "isDeletedDataGridViewCheckBoxColumn";
            isDeletedDataGridViewCheckBoxColumn.ReadOnly = true;
            isDeletedDataGridViewCheckBoxColumn.Visible = false;
            // 
            // createdByUserIdDataGridViewTextBoxColumn
            // 
            createdByUserIdDataGridViewTextBoxColumn.DataPropertyName = "CreatedByUserId";
            createdByUserIdDataGridViewTextBoxColumn.HeaderText = "CreatedByUserId";
            createdByUserIdDataGridViewTextBoxColumn.Name = "createdByUserIdDataGridViewTextBoxColumn";
            createdByUserIdDataGridViewTextBoxColumn.ReadOnly = true;
            createdByUserIdDataGridViewTextBoxColumn.Visible = false;
            // 
            // createdOnDateDataGridViewTextBoxColumn
            // 
            createdOnDateDataGridViewTextBoxColumn.DataPropertyName = "CreatedOnDate";
            createdOnDateDataGridViewTextBoxColumn.HeaderText = "CreatedOnDate";
            createdOnDateDataGridViewTextBoxColumn.Name = "createdOnDateDataGridViewTextBoxColumn";
            createdOnDateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // lastModifiedByUserIdDataGridViewTextBoxColumn
            // 
            lastModifiedByUserIdDataGridViewTextBoxColumn.DataPropertyName = "LastModifiedByUserId";
            lastModifiedByUserIdDataGridViewTextBoxColumn.HeaderText = "LastModifiedByUserId";
            lastModifiedByUserIdDataGridViewTextBoxColumn.Name = "lastModifiedByUserIdDataGridViewTextBoxColumn";
            lastModifiedByUserIdDataGridViewTextBoxColumn.ReadOnly = true;
            lastModifiedByUserIdDataGridViewTextBoxColumn.Visible = false;
            // 
            // lastModifiedOnDateDataGridViewTextBoxColumn
            // 
            lastModifiedOnDateDataGridViewTextBoxColumn.DataPropertyName = "LastModifiedOnDate";
            lastModifiedOnDateDataGridViewTextBoxColumn.HeaderText = "LastModifiedOnDate";
            lastModifiedOnDateDataGridViewTextBoxColumn.Name = "lastModifiedOnDateDataGridViewTextBoxColumn";
            lastModifiedOnDateDataGridViewTextBoxColumn.ReadOnly = true;
            lastModifiedOnDateDataGridViewTextBoxColumn.Visible = false;
            // 
            // passwordResetTokenDataGridViewTextBoxColumn
            // 
            passwordResetTokenDataGridViewTextBoxColumn.DataPropertyName = "PasswordResetToken";
            passwordResetTokenDataGridViewTextBoxColumn.HeaderText = "PasswordResetToken";
            passwordResetTokenDataGridViewTextBoxColumn.Name = "passwordResetTokenDataGridViewTextBoxColumn";
            passwordResetTokenDataGridViewTextBoxColumn.ReadOnly = true;
            passwordResetTokenDataGridViewTextBoxColumn.Visible = false;
            // 
            // passwordResetExpirationDataGridViewTextBoxColumn
            // 
            passwordResetExpirationDataGridViewTextBoxColumn.DataPropertyName = "PasswordResetExpiration";
            passwordResetExpirationDataGridViewTextBoxColumn.HeaderText = "PasswordResetExpiration";
            passwordResetExpirationDataGridViewTextBoxColumn.Name = "passwordResetExpirationDataGridViewTextBoxColumn";
            passwordResetExpirationDataGridViewTextBoxColumn.ReadOnly = true;
            passwordResetExpirationDataGridViewTextBoxColumn.Visible = false;
            // 
            // contentWorkflowStatePermissionDataGridViewTextBoxColumn
            // 
            contentWorkflowStatePermissionDataGridViewTextBoxColumn.DataPropertyName = "ContentWorkflowStatePermission";
            contentWorkflowStatePermissionDataGridViewTextBoxColumn.HeaderText = "ContentWorkflowStatePermission";
            contentWorkflowStatePermissionDataGridViewTextBoxColumn.Name = "contentWorkflowStatePermissionDataGridViewTextBoxColumn";
            contentWorkflowStatePermissionDataGridViewTextBoxColumn.ReadOnly = true;
            contentWorkflowStatePermissionDataGridViewTextBoxColumn.Visible = false;
            // 
            // coreMessagingSubscriptionsDataGridViewTextBoxColumn
            // 
            coreMessagingSubscriptionsDataGridViewTextBoxColumn.DataPropertyName = "CoreMessagingSubscriptions";
            coreMessagingSubscriptionsDataGridViewTextBoxColumn.HeaderText = "CoreMessagingSubscriptions";
            coreMessagingSubscriptionsDataGridViewTextBoxColumn.Name = "coreMessagingSubscriptionsDataGridViewTextBoxColumn";
            coreMessagingSubscriptionsDataGridViewTextBoxColumn.ReadOnly = true;
            coreMessagingSubscriptionsDataGridViewTextBoxColumn.Visible = false;
            // 
            // desktopModulePermissionDataGridViewTextBoxColumn
            // 
            desktopModulePermissionDataGridViewTextBoxColumn.DataPropertyName = "DesktopModulePermission";
            desktopModulePermissionDataGridViewTextBoxColumn.HeaderText = "DesktopModulePermission";
            desktopModulePermissionDataGridViewTextBoxColumn.Name = "desktopModulePermissionDataGridViewTextBoxColumn";
            desktopModulePermissionDataGridViewTextBoxColumn.ReadOnly = true;
            desktopModulePermissionDataGridViewTextBoxColumn.Visible = false;
            // 
            // folderPermissionDataGridViewTextBoxColumn
            // 
            folderPermissionDataGridViewTextBoxColumn.DataPropertyName = "FolderPermission";
            folderPermissionDataGridViewTextBoxColumn.HeaderText = "FolderPermission";
            folderPermissionDataGridViewTextBoxColumn.Name = "folderPermissionDataGridViewTextBoxColumn";
            folderPermissionDataGridViewTextBoxColumn.ReadOnly = true;
            folderPermissionDataGridViewTextBoxColumn.Visible = false;
            // 
            // modulePermissionDataGridViewTextBoxColumn
            // 
            modulePermissionDataGridViewTextBoxColumn.DataPropertyName = "ModulePermission";
            modulePermissionDataGridViewTextBoxColumn.HeaderText = "ModulePermission";
            modulePermissionDataGridViewTextBoxColumn.Name = "modulePermissionDataGridViewTextBoxColumn";
            modulePermissionDataGridViewTextBoxColumn.ReadOnly = true;
            modulePermissionDataGridViewTextBoxColumn.Visible = false;
            // 
            // passwordHistoryDataGridViewTextBoxColumn
            // 
            passwordHistoryDataGridViewTextBoxColumn.DataPropertyName = "PasswordHistory";
            passwordHistoryDataGridViewTextBoxColumn.HeaderText = "PasswordHistory";
            passwordHistoryDataGridViewTextBoxColumn.Name = "passwordHistoryDataGridViewTextBoxColumn";
            passwordHistoryDataGridViewTextBoxColumn.ReadOnly = true;
            passwordHistoryDataGridViewTextBoxColumn.Visible = false;
            // 
            // personaBarMenuPermissionDataGridViewTextBoxColumn
            // 
            personaBarMenuPermissionDataGridViewTextBoxColumn.DataPropertyName = "PersonaBarMenuPermission";
            personaBarMenuPermissionDataGridViewTextBoxColumn.HeaderText = "PersonaBarMenuPermission";
            personaBarMenuPermissionDataGridViewTextBoxColumn.Name = "personaBarMenuPermissionDataGridViewTextBoxColumn";
            personaBarMenuPermissionDataGridViewTextBoxColumn.ReadOnly = true;
            personaBarMenuPermissionDataGridViewTextBoxColumn.Visible = false;
            // 
            // portalPermissionDataGridViewTextBoxColumn
            // 
            portalPermissionDataGridViewTextBoxColumn.DataPropertyName = "PortalPermission";
            portalPermissionDataGridViewTextBoxColumn.HeaderText = "PortalPermission";
            portalPermissionDataGridViewTextBoxColumn.Name = "portalPermissionDataGridViewTextBoxColumn";
            portalPermissionDataGridViewTextBoxColumn.ReadOnly = true;
            portalPermissionDataGridViewTextBoxColumn.Visible = false;
            // 
            // profileDataGridViewTextBoxColumn
            // 
            profileDataGridViewTextBoxColumn.DataPropertyName = "Profile";
            profileDataGridViewTextBoxColumn.HeaderText = "Profile";
            profileDataGridViewTextBoxColumn.Name = "profileDataGridViewTextBoxColumn";
            profileDataGridViewTextBoxColumn.ReadOnly = true;
            profileDataGridViewTextBoxColumn.Visible = false;
            // 
            // relationshipsDataGridViewTextBoxColumn
            // 
            relationshipsDataGridViewTextBoxColumn.DataPropertyName = "Relationships";
            relationshipsDataGridViewTextBoxColumn.HeaderText = "Relationships";
            relationshipsDataGridViewTextBoxColumn.Name = "relationshipsDataGridViewTextBoxColumn";
            relationshipsDataGridViewTextBoxColumn.ReadOnly = true;
            relationshipsDataGridViewTextBoxColumn.Visible = false;
            // 
            // tabPermissionDataGridViewTextBoxColumn
            // 
            tabPermissionDataGridViewTextBoxColumn.DataPropertyName = "TabPermission";
            tabPermissionDataGridViewTextBoxColumn.HeaderText = "TabPermission";
            tabPermissionDataGridViewTextBoxColumn.Name = "tabPermissionDataGridViewTextBoxColumn";
            tabPermissionDataGridViewTextBoxColumn.ReadOnly = true;
            tabPermissionDataGridViewTextBoxColumn.Visible = false;
            // 
            // userAuthenticationDataGridViewTextBoxColumn
            // 
            userAuthenticationDataGridViewTextBoxColumn.DataPropertyName = "UserAuthentication";
            userAuthenticationDataGridViewTextBoxColumn.HeaderText = "UserAuthentication";
            userAuthenticationDataGridViewTextBoxColumn.Name = "userAuthenticationDataGridViewTextBoxColumn";
            userAuthenticationDataGridViewTextBoxColumn.ReadOnly = true;
            userAuthenticationDataGridViewTextBoxColumn.Visible = false;
            // 
            // userPortalsDataGridViewTextBoxColumn
            // 
            userPortalsDataGridViewTextBoxColumn.DataPropertyName = "UserPortals";
            userPortalsDataGridViewTextBoxColumn.HeaderText = "UserPortals";
            userPortalsDataGridViewTextBoxColumn.Name = "userPortalsDataGridViewTextBoxColumn";
            userPortalsDataGridViewTextBoxColumn.ReadOnly = true;
            userPortalsDataGridViewTextBoxColumn.Visible = false;
            // 
            // userProfileDataGridViewTextBoxColumn
            // 
            userProfileDataGridViewTextBoxColumn.DataPropertyName = "UserProfile";
            userProfileDataGridViewTextBoxColumn.HeaderText = "UserProfile";
            userProfileDataGridViewTextBoxColumn.Name = "userProfileDataGridViewTextBoxColumn";
            userProfileDataGridViewTextBoxColumn.ReadOnly = true;
            userProfileDataGridViewTextBoxColumn.Visible = false;
            // 
            // userRelationshipPreferencesDataGridViewTextBoxColumn
            // 
            userRelationshipPreferencesDataGridViewTextBoxColumn.DataPropertyName = "UserRelationshipPreferences";
            userRelationshipPreferencesDataGridViewTextBoxColumn.HeaderText = "UserRelationshipPreferences";
            userRelationshipPreferencesDataGridViewTextBoxColumn.Name = "userRelationshipPreferencesDataGridViewTextBoxColumn";
            userRelationshipPreferencesDataGridViewTextBoxColumn.ReadOnly = true;
            userRelationshipPreferencesDataGridViewTextBoxColumn.Visible = false;
            // 
            // userRelationshipsRelatedUserDataGridViewTextBoxColumn
            // 
            userRelationshipsRelatedUserDataGridViewTextBoxColumn.DataPropertyName = "UserRelationshipsRelatedUser";
            userRelationshipsRelatedUserDataGridViewTextBoxColumn.HeaderText = "UserRelationshipsRelatedUser";
            userRelationshipsRelatedUserDataGridViewTextBoxColumn.Name = "userRelationshipsRelatedUserDataGridViewTextBoxColumn";
            userRelationshipsRelatedUserDataGridViewTextBoxColumn.ReadOnly = true;
            userRelationshipsRelatedUserDataGridViewTextBoxColumn.Visible = false;
            // 
            // userRelationshipsUserDataGridViewTextBoxColumn
            // 
            userRelationshipsUserDataGridViewTextBoxColumn.DataPropertyName = "UserRelationshipsUser";
            userRelationshipsUserDataGridViewTextBoxColumn.HeaderText = "UserRelationshipsUser";
            userRelationshipsUserDataGridViewTextBoxColumn.Name = "userRelationshipsUserDataGridViewTextBoxColumn";
            userRelationshipsUserDataGridViewTextBoxColumn.ReadOnly = true;
            userRelationshipsUserDataGridViewTextBoxColumn.Visible = false;
            // 
            // userRolesDataGridViewTextBoxColumn
            // 
            userRolesDataGridViewTextBoxColumn.DataPropertyName = "UserRoles";
            userRolesDataGridViewTextBoxColumn.HeaderText = "UserRoles";
            userRolesDataGridViewTextBoxColumn.Name = "userRolesDataGridViewTextBoxColumn";
            userRolesDataGridViewTextBoxColumn.ReadOnly = true;
            userRolesDataGridViewTextBoxColumn.Visible = false;
            // 
            // usersOnlineDataGridViewTextBoxColumn
            // 
            usersOnlineDataGridViewTextBoxColumn.DataPropertyName = "UsersOnline";
            usersOnlineDataGridViewTextBoxColumn.HeaderText = "UsersOnline";
            usersOnlineDataGridViewTextBoxColumn.Name = "usersOnlineDataGridViewTextBoxColumn";
            usersOnlineDataGridViewTextBoxColumn.ReadOnly = true;
            usersOnlineDataGridViewTextBoxColumn.Visible = false;
            // 
            // usersBindingSource
            // 
            usersBindingSource.DataSource = typeof(Models.Users);
            // 
            // button1
            // 
            button1.DialogResult = DialogResult.OK;
            button1.Location = new Point(288, 341);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 1;
            button1.Text = "Bezár";
            button1.UseVisualStyleBackColor = true;
            // 
            // textBoxEdzoSzuro
            // 
            textBoxEdzoSzuro.Cursor = Cursors.IBeam;
            textBoxEdzoSzuro.Location = new Point(12, 36);
            textBoxEdzoSzuro.Name = "textBoxEdzoSzuro";
            textBoxEdzoSzuro.Size = new Size(191, 23);
            textBoxEdzoSzuro.TabIndex = 2;
            textBoxEdzoSzuro.TextChanged += textBoxEdzoSzuro_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(12, 16);
            label1.Name = "label1";
            label1.Size = new Size(166, 17);
            label1.TabIndex = 3;
            label1.Text = "Keresés Username alapján";
            // 
            // button2
            // 
            button2.DialogResult = DialogResult.OK;
            button2.Location = new Point(209, 36);
            button2.Name = "button2";
            button2.Size = new Size(142, 23);
            button2.TabIndex = 4;
            button2.Text = "Id vágólapra másolása";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // FormDNNUsers
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(375, 376);
            Controls.Add(button2);
            Controls.Add(textBoxEdzoSzuro);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(dataGridView1);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Name = "FormDNNUsers";
            Text = "FormDNNUsers";
            Load += FormDNNUsers_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)usersBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn userIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn usernameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn firstNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn lastNameDataGridViewTextBoxColumn;
        private DataGridViewCheckBoxColumn isSuperUserDataGridViewCheckBoxColumn;
        private DataGridViewTextBoxColumn affiliateIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn displayNameDataGridViewTextBoxColumn;
        private DataGridViewCheckBoxColumn updatePasswordDataGridViewCheckBoxColumn;
        private DataGridViewTextBoxColumn lastIpaddressDataGridViewTextBoxColumn;
        private DataGridViewCheckBoxColumn isDeletedDataGridViewCheckBoxColumn;
        private DataGridViewTextBoxColumn createdByUserIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn createdOnDateDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn lastModifiedByUserIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn lastModifiedOnDateDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn passwordResetTokenDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn passwordResetExpirationDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn contentWorkflowStatePermissionDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn coreMessagingSubscriptionsDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn desktopModulePermissionDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn folderPermissionDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn modulePermissionDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn passwordHistoryDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn personaBarMenuPermissionDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn portalPermissionDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn profileDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn relationshipsDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn tabPermissionDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn userAuthenticationDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn userPortalsDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn userProfileDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn userRelationshipPreferencesDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn userRelationshipsRelatedUserDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn userRelationshipsUserDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn userRolesDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn usersOnlineDataGridViewTextBoxColumn;
        private BindingSource usersBindingSource;
        private Button button1;
        private TextBox textBoxEdzoSzuro;
        private Label label1;
        private Button button2;
    }
}