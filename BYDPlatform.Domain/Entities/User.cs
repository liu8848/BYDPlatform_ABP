using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
using Volo.Abp.Domain.Entities;

namespace BYDPlatform.Domain.Entities;

[Table("user")]
public class User:Entity<int>
{
    [Column("user_name",TypeName = "varchar(20)")]
    [Comment("用户名")]
    public string UserName { get; set; }

    [Column("user_nick_name",TypeName = "varchar(20)")]
    [Comment("用户别名")]
    public string UserNickName { get; set; }

    [Column("password",TypeName = "varchar(20)")]
    [Comment("密码")]
    public string Password { get; set; }
    
}