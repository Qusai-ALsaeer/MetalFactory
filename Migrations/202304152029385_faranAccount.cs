namespace Acco.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class faranAccount : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.sysdiagrams",
                c => new
                    {
                        diagram_id = c.Int(nullable: false, identity: true),
                        name = c.String(nullable: false, maxLength: 128),
                        principal_id = c.Int(nullable: false),
                        version = c.Int(),
                        definition = c.Binary(),
                    })
                .PrimaryKey(t => t.diagram_id);
            
            CreateTable(
                "dbo.tb_account",
                c => new
                    {
                        id_ac = c.Int(nullable: false, identity: true),
                        ac_num = c.Int(),
                        ac_level = c.Int(),
                        ac_name = c.String(maxLength: 50),
                        ac_type = c.Boolean(),
                        ac_fnum = c.Int(),
                        ac_open = c.Int(),
                        ac_final = c.Int(),
                        ac_cu = c.Int(),
                    })
                .PrimaryKey(t => t.id_ac);
            
            CreateTable(
                "dbo.tb_car",
                c => new
                    {
                        id_car = c.Int(nullable: false, identity: true),
                        car_name = c.String(maxLength: 50),
                        car_num = c.String(maxLength: 50),
                        car_space = c.String(maxLength: 50),
                    })
                .PrimaryKey(t => t.id_car);
            
            CreateTable(
                "dbo.tb_category",
                c => new
                    {
                        id_cat = c.Int(nullable: false, identity: true),
                        cat_name = c.String(maxLength: 50),
                    })
                .PrimaryKey(t => t.id_cat);
            
            CreateTable(
                "dbo.tb_company",
                c => new
                    {
                        comp_name = c.String(nullable: false, maxLength: 50),
                        address = c.String(maxLength: 70),
                        phone = c.String(maxLength: 50),
                        logo = c.Binary(storeType: "image"),
                    })
                .PrimaryKey(t => t.comp_name);
            
            CreateTable(
                "dbo.tb_currency",
                c => new
                    {
                        id_cu = c.Int(nullable: false, identity: true),
                        cu_name = c.String(maxLength: 30),
                        cu_sym = c.String(maxLength: 10, fixedLength: true),
                        cu_part = c.String(maxLength: 10, fixedLength: true),
                        cu_iso = c.String(maxLength: 10, fixedLength: true),
                    })
                .PrimaryKey(t => t.id_cu);
            
            CreateTable(
                "dbo.tb_employee",
                c => new
                    {
                        id_em = c.Int(nullable: false, identity: true),
                        emp_name = c.String(maxLength: 50),
                        jop = c.Int(),
                        emp_sal = c.Int(),
                        date = c.DateTime(storeType: "date"),
                    })
                .PrimaryKey(t => t.id_em);
            
            CreateTable(
                "dbo.tb_entry",
                c => new
                    {
                        id_ent = c.Int(nullable: false, identity: true),
                        date = c.DateTime(storeType: "date"),
                        id_cu = c.Int(),
                        explan = c.String(maxLength: 100),
                        c_total = c.Double(),
                        d_total = c.Double(),
                        note = c.String(maxLength: 100),
                    })
                .PrimaryKey(t => t.id_ent);
            
            CreateTable(
                "dbo.tb_entry_d",
                c => new
                    {
                        id_dent = c.Int(nullable: false, identity: true),
                        ser_num = c.Int(),
                        id_ent = c.Int(),
                        ent_credit = c.Double(),
                        ent_debit = c.Double(),
                        ac_credit = c.Int(),
                        ac_debit = c.Int(),
                        expaln = c.String(maxLength: 100),
                        note = c.String(maxLength: 100),
                    })
                .PrimaryKey(t => t.id_dent);
            
            CreateTable(
                "dbo.tb_final",
                c => new
                    {
                        id_fin = c.Int(nullable: false, identity: true),
                        f_num = c.String(nullable: false, maxLength: 20),
                        f_name = c.String(nullable: false, maxLength: 50),
                    })
                .PrimaryKey(t => t.id_fin);
            
            CreateTable(
                "dbo.tb_fran",
                c => new
                    {
                        id_farn = c.Int(nullable: false, identity: true),
                        far_name = c.String(maxLength: 50),
                        id_Acco = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.id_farn);
            
            CreateTable(
                "dbo.tb_general",
                c => new
                    {
                        id = c.Int(nullable: false),
                        date = c.DateTime(storeType: "date"),
                        credit = c.Double(),
                        debit = c.Double(),
                        id_cur = c.Int(),
                        mo_num = c.Int(nullable: false),
                        ser_num = c.String(maxLength: 10),
                        account = c.Int(),
                        explan = c.String(maxLength: 100),
                        past_date = c.String(maxLength: 50),
                        g_check = c.Boolean(),
                        transfer = c.Boolean(),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.tb_item",
                c => new
                    {
                        id_it = c.Int(nullable: false, identity: true),
                        it_name = c.String(maxLength: 50),
                        cat_name = c.Int(),
                        id_cat = c.Int(nullable: false),
                        u_name = c.Int(),
                    })
                .PrimaryKey(t => t.id_it);
            
            CreateTable(
                "dbo.tb_jop",
                c => new
                    {
                        id_jop = c.Int(nullable: false, identity: true),
                        jop_name = c.String(maxLength: 50),
                    })
                .PrimaryKey(t => t.id_jop);
            
            CreateTable(
                "dbo.tb_manufact",
                c => new
                    {
                        id_maunf = c.Int(nullable: false, identity: true),
                        date = c.DateTime(storeType: "date"),
                        sup_name = c.Int(),
                        oven = c.Int(),
                        ovener = c.Int(),
                        num_card = c.String(maxLength: 10),
                        car = c.Int(),
                        quntity = c.Double(),
                        price = c.Double(),
                        total = c.Double(),
                        note = c.Double(),
                    })
                .PrimaryKey(t => t.id_maunf);
            
            CreateTable(
                "dbo.tb_motion",
                c => new
                    {
                        id_mo = c.Int(nullable: false, identity: true),
                        mo_name = c.String(maxLength: 50),
                    })
                .PrimaryKey(t => t.id_mo);
            
            CreateTable(
                "dbo.tb_oven",
                c => new
                    {
                        id_oven = c.Int(nullable: false, identity: true),
                        ove_name = c.String(maxLength: 50),
                    })
                .PrimaryKey(t => t.id_oven);
            
            CreateTable(
                "dbo.tb_payment",
                c => new
                    {
                        id_pay = c.Int(nullable: false, identity: true),
                        pay_date = c.DateTime(storeType: "date"),
                        id_cur = c.Int(),
                        pay_exch = c.Double(),
                        pay_debit = c.Int(),
                        pay_credit = c.Int(),
                        explan = c.String(maxLength: 100),
                        pay_amount = c.Double(),
                        note = c.String(maxLength: 100),
                    })
                .PrimaryKey(t => t.id_pay);
            
            CreateTable(
                "dbo.tb_purchases",
                c => new
                    {
                        id_inv = c.Int(nullable: false, identity: true),
                        inv_date = c.String(maxLength: 10, fixedLength: true),
                        id_cur = c.Int(),
                        inv_total = c.Double(),
                        inv_explan = c.String(maxLength: 100),
                        ac_debit = c.Int(),
                        ac_credit = c.Int(),
                        card_name = c.String(maxLength: 50),
                        num_weight = c.Int(),
                        num_cou = c.Int(),
                        inv_discount = c.Double(),
                        inv_net = c.Double(),
                        note = c.String(maxLength: 100),
                    })
                .PrimaryKey(t => t.id_inv);
            
            CreateTable(
                "dbo.tb_purchases_d",
                c => new
                    {
                        id_inv_d = c.Int(nullable: false, identity: true),
                        ser_num = c.Int(),
                        id_p = c.Int(),
                        id_mat = c.Int(),
                        explan = c.String(maxLength: 100),
                        quantity = c.Double(),
                        id_un = c.Int(),
                        price = c.Double(),
                        total = c.Double(),
                        discount = c.Double(),
                        net = c.Double(),
                    })
                .PrimaryKey(t => t.id_inv_d);
            
            CreateTable(
                "dbo.tb_receipt",
                c => new
                    {
                        id_rec = c.Int(nullable: false, identity: true),
                        rec_date = c.DateTime(storeType: "date"),
                        id_cur = c.Int(),
                        exch = c.Double(),
                        rec_debit = c.Int(),
                        rec_credit = c.Int(),
                        explane = c.String(maxLength: 100),
                        amount = c.Double(),
                        note = c.String(maxLength: 100),
                    })
                .PrimaryKey(t => t.id_rec);
            
            CreateTable(
                "dbo.tb_salary",
                c => new
                    {
                        id_s = c.Int(nullable: false, identity: true),
                        date = c.DateTime(storeType: "date"),
                        id_cu = c.Int(),
                        exch = c.Double(),
                        total = c.Double(),
                        explan = c.String(maxLength: 100),
                        em_count = c.String(maxLength: 10),
                        id_week = c.Int(),
                    })
                .PrimaryKey(t => t.id_s);
            
            CreateTable(
                "dbo.tb_salary_d",
                c => new
                    {
                        id_s_d = c.Int(nullable: false, identity: true),
                        id_s = c.Int(),
                        ser_num = c.Int(),
                        id_em = c.Int(),
                        id_job = c.Int(),
                        salary = c.Double(),
                        day_count = c.Double(),
                        reward = c.Double(),
                        discount = c.Double(),
                        net = c.Double(),
                        note = c.String(maxLength: 100),
                    })
                .PrimaryKey(t => t.id_s_d);
            
            CreateTable(
                "dbo.tb_sale_d",
                c => new
                    {
                        id_sal_d = c.Int(nullable: false, identity: true),
                        ser_num = c.String(maxLength: 10),
                        id_sal = c.Int(),
                        id_mat = c.Int(),
                        quntity = c.Double(),
                        id_un = c.Int(),
                        price = c.Double(),
                        discount = c.Double(),
                        net = c.Double(),
                    })
                .PrimaryKey(t => t.id_sal_d);
            
            CreateTable(
                "dbo.tb_sales",
                c => new
                    {
                        id_sal = c.Int(nullable: false, identity: true),
                        sal_date = c.DateTime(storeType: "date"),
                        id_cur = c.Int(),
                        sal_total = c.Double(),
                        explan = c.String(maxLength: 100),
                        ac_debit = c.Int(),
                        ac_credit = c.Int(),
                        num_weight = c.String(maxLength: 10),
                        discount = c.Double(),
                        net = c.Double(),
                        note = c.String(maxLength: 100),
                    })
                .PrimaryKey(t => t.id_sal);
            
            CreateTable(
                "dbo.tb_supervisor",
                c => new
                    {
                        id_sup = c.Int(nullable: false, identity: true),
                        sup_name = c.String(maxLength: 50),
                        note = c.String(maxLength: 50),
                    })
                .PrimaryKey(t => t.id_sup);
            
            CreateTable(
                "dbo.tb_transfer",
                c => new
                    {
                        id_bt = c.Int(nullable: false, identity: true),
                        bt_name = c.String(maxLength: 50),
                        bt_carname = c.String(maxLength: 50),
                        id_inv = c.Int(),
                        num_w = c.String(maxLength: 50),
                        weight = c.Int(),
                        bt_amount = c.Double(),
                        bt_total = c.Double(),
                        bt_discount = c.Double(),
                        bt_net = c.Double(),
                        id_cur = c.Int(),
                        bt_date = c.DateTime(storeType: "date"),
                    })
                .PrimaryKey(t => t.id_bt);
            
            CreateTable(
                "dbo.tb_unit",
                c => new
                    {
                        id_unit = c.Int(nullable: false, identity: true),
                        u_name = c.String(maxLength: 50),
                    })
                .PrimaryKey(t => t.id_unit);
            
            CreateTable(
                "dbo.tb_user",
                c => new
                    {
                        id_user = c.Int(nullable: false, identity: true),
                        user_name = c.String(maxLength: 50),
                        user_type = c.String(maxLength: 20),
                    })
                .PrimaryKey(t => t.id_user);
            
            CreateTable(
                "dbo.tb_week",
                c => new
                    {
                        id_week = c.Int(nullable: false, identity: true),
                        we_name = c.String(maxLength: 50),
                        from_date = c.DateTime(storeType: "date"),
                        to_date = c.DateTime(storeType: "date"),
                        note = c.String(maxLength: 100),
                    })
                .PrimaryKey(t => t.id_week);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.tb_week");
            DropTable("dbo.tb_user");
            DropTable("dbo.tb_unit");
            DropTable("dbo.tb_transfer");
            DropTable("dbo.tb_supervisor");
            DropTable("dbo.tb_sales");
            DropTable("dbo.tb_sale_d");
            DropTable("dbo.tb_salary_d");
            DropTable("dbo.tb_salary");
            DropTable("dbo.tb_receipt");
            DropTable("dbo.tb_purchases_d");
            DropTable("dbo.tb_purchases");
            DropTable("dbo.tb_payment");
            DropTable("dbo.tb_oven");
            DropTable("dbo.tb_motion");
            DropTable("dbo.tb_manufact");
            DropTable("dbo.tb_jop");
            DropTable("dbo.tb_item");
            DropTable("dbo.tb_general");
            DropTable("dbo.tb_fran");
            DropTable("dbo.tb_final");
            DropTable("dbo.tb_entry_d");
            DropTable("dbo.tb_entry");
            DropTable("dbo.tb_employee");
            DropTable("dbo.tb_currency");
            DropTable("dbo.tb_company");
            DropTable("dbo.tb_category");
            DropTable("dbo.tb_car");
            DropTable("dbo.tb_account");
            DropTable("dbo.sysdiagrams");
        }
    }
}
