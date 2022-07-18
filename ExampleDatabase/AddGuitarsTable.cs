using FluentMigrator;

namespace ExampleDatabase
{
    [Migration(1)]
    public class AddGuitarsTable : Migration
    {
        public override void Up()
        {
            Create.Table("guitars")
                .WithColumn("guitar_id").AsInt64().PrimaryKey().Identity()
                .WithColumn("brand").AsString()
                .WithColumn("model").AsString()
                .WithColumn("string_count").AsInt32()
                .WithColumn("body_style").AsString()
                .WithColumn("scale_length").AsFloat();
        }

        public override void Down()
        {
            Delete.Table("guitars");
        }
    }
}