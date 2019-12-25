﻿// <auto-generated />
using System;
using IEManageSystem.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace IEManageSystem.Migrations
{
    [DbContext(typeof(IEManageSystemDbContext))]
    partial class IEManageSystemDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.4-servicing-10062")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("IEManageSystem.ApiAuthorization.DomainModel.ApiScopes.ApiScope", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("ApiManageScopeId");

                    b.Property<int?>("ApiQueryScopeId");

                    b.Property<string>("DisplayName");

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.HasIndex("ApiManageScopeId");

                    b.HasIndex("ApiQueryScopeId");

                    b.ToTable("ApiScope");
                });

            modelBuilder.Entity("IEManageSystem.ApiAuthorization.DomainModel.ApiScopes.ApiScopePermission", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ApiScopeId");

                    b.Property<int?>("ApiScopeNodeId");

                    b.Property<int>("PermissionId");

                    b.HasKey("Id");

                    b.HasIndex("ApiScopeNodeId");

                    b.HasIndex("PermissionId");

                    b.ToTable("ApiScopePermission");
                });

            modelBuilder.Entity("IEManageSystem.ApiAuthorization.DomainModel.ApiScopes.AuthorizationNodes.ApiScopeNode", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Discriminator")
                        .IsRequired();

                    b.HasKey("Id");

                    b.ToTable("ApiScopeNode");

                    b.HasDiscriminator<string>("Discriminator").HasValue("ApiScopeNode");
                });

            modelBuilder.Entity("IEManageSystem.CMS.DomainModel.CmsComponent", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .IsRequired();

                    b.HasKey("Id");

                    b.ToTable("CmsComponents");
                });

            modelBuilder.Entity("IEManageSystem.CMS.DomainModel.Menus.MenuBase", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("CompositeMenuId");

                    b.Property<string>("Discriminator")
                        .IsRequired();

                    b.Property<string>("DisplayName")
                        .IsRequired();

                    b.Property<string>("Icon");

                    b.Property<string>("Name")
                        .IsRequired();

                    b.Property<int?>("PageDataId");

                    b.HasKey("Id");

                    b.HasIndex("CompositeMenuId");

                    b.HasIndex("PageDataId");

                    b.ToTable("Menus");

                    b.HasDiscriminator<string>("Discriminator").HasValue("MenuBase");
                });

            modelBuilder.Entity("IEManageSystem.CMS.DomainModel.PageDatas.ContentComponentData", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Field1");

                    b.Property<string>("Field2");

                    b.Property<string>("Field3");

                    b.Property<string>("Field4");

                    b.Property<string>("Field5");

                    b.Property<int>("PageDataId");

                    b.Property<string>("Sign");

                    b.HasKey("Id");

                    b.HasIndex("PageDataId");

                    b.ToTable("ContentComponentData");
                });

            modelBuilder.Entity("IEManageSystem.CMS.DomainModel.PageDatas.PageData", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name");

                    b.Property<int>("PageId");

                    b.Property<string>("Title");

                    b.HasKey("Id");

                    b.HasIndex("PageId");

                    b.ToTable("PageData");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Index",
                            PageId = 1,
                            Title = "首页"
                        });
                });

            modelBuilder.Entity("IEManageSystem.CMS.DomainModel.Pages.PageBase", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description");

                    b.Property<string>("Discriminator")
                        .IsRequired();

                    b.Property<string>("DisplayName");

                    b.Property<string>("Name")
                        .IsRequired();

                    b.HasKey("Id");

                    b.ToTable("Pages");

                    b.HasDiscriminator<string>("Discriminator").HasValue("PageBase");
                });

            modelBuilder.Entity("IEManageSystem.CMS.DomainModel.Pages.PageComponentBase", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("CmsComponentId");

                    b.Property<string>("Discriminator")
                        .IsRequired();

                    b.Property<string>("Name");

                    b.Property<int>("PageId");

                    b.Property<string>("ParentSign");

                    b.Property<string>("Sign");

                    b.HasKey("Id");

                    b.HasIndex("CmsComponentId");

                    b.HasIndex("PageId");

                    b.ToTable("PageComponentBase");

                    b.HasDiscriminator<string>("Discriminator").HasValue("PageComponentBase");
                });

            modelBuilder.Entity("IEManageSystem.CMS.DomainModel.Pages.PageComponentSetting", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("DisplayName");

                    b.Property<string>("Field1");

                    b.Property<string>("Field2");

                    b.Property<string>("Field3");

                    b.Property<string>("Field4");

                    b.Property<string>("Field5");

                    b.Property<string>("Name");

                    b.Property<int?>("PageComponentBaseId");

                    b.HasKey("Id");

                    b.HasIndex("PageComponentBaseId");

                    b.ToTable("PageComponentSetting");
                });

            modelBuilder.Entity("IEManageSystem.Common.DomainModel.SiteSetting", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("DisplayName");

                    b.Property<string>("Group");

                    b.Property<string>("Key");

                    b.Property<string>("Value");

                    b.HasKey("Id");

                    b.ToTable("SiteSettings");
                });

            modelBuilder.Entity("IEManageSystem.Entitys.Authorization.Permissions.Permission", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Describe");

                    b.Property<string>("DisplayName");

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("Permission");
                });

            modelBuilder.Entity("IEManageSystem.Entitys.Authorization.Roles.Role", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Describe");

                    b.Property<string>("DisplayName");

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("Role");
                });

            modelBuilder.Entity("IEManageSystem.Entitys.Authorization.Roles.RolePermission", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("PermissionId");

                    b.Property<int>("RoleId");

                    b.HasKey("Id");

                    b.HasIndex("PermissionId");

                    b.HasIndex("RoleId");

                    b.ToTable("RolePermission");
                });

            modelBuilder.Entity("IEManageSystem.Entitys.Authorization.Users.Accounts.Account", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(60);

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasMaxLength(15);

                    b.HasKey("Id");

                    b.ToTable("Account");
                });

            modelBuilder.Entity("IEManageSystem.Entitys.Authorization.Users.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("AccountId");

                    b.Property<string>("Address");

                    b.Property<DateTime>("BirthDate");

                    b.Property<string>("EmailAddress");

                    b.Property<string>("HeadSculpture");

                    b.Property<string>("IDNumber");

                    b.Property<string>("Name")
                        .HasMaxLength(20);

                    b.Property<string>("PersonSignature");

                    b.Property<string>("Phone");

                    b.Property<string>("RealName");

                    b.Property<bool>("Sex");

                    b.Property<int?>("TenantId");

                    b.HasKey("Id");

                    b.HasIndex("AccountId");

                    b.ToTable("User");
                });

            modelBuilder.Entity("IEManageSystem.Entitys.Authorization.Users.UserRole", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("RoleId");

                    b.Property<int>("UserId");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.HasIndex("UserId");

                    b.ToTable("UserRole");
                });

            modelBuilder.Entity("IEManageSystem.ApiAuthorization.DomainModel.ApiScopes.AuthorizationNodes.ApiManageScope", b =>
                {
                    b.HasBaseType("IEManageSystem.ApiAuthorization.DomainModel.ApiScopes.AuthorizationNodes.ApiScopeNode");

                    b.HasDiscriminator().HasValue("ApiManageScope");
                });

            modelBuilder.Entity("IEManageSystem.ApiAuthorization.DomainModel.ApiScopes.AuthorizationNodes.ApiQueryScope", b =>
                {
                    b.HasBaseType("IEManageSystem.ApiAuthorization.DomainModel.ApiScopes.AuthorizationNodes.ApiScopeNode");

                    b.HasDiscriminator().HasValue("ApiQueryScope");
                });

            modelBuilder.Entity("IEManageSystem.CMS.DomainModel.Menus.CompositeMenu", b =>
                {
                    b.HasBaseType("IEManageSystem.CMS.DomainModel.Menus.MenuBase");

                    b.HasDiscriminator().HasValue("CompositeMenu");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Discriminator = "CompositeMenu",
                            DisplayName = "首页",
                            Icon = "oi-home",
                            Name = "Home"
                        },
                        new
                        {
                            Id = 2,
                            Discriminator = "CompositeMenu",
                            DisplayName = "游戏",
                            Icon = "oi-dial",
                            Name = "Game"
                        },
                        new
                        {
                            Id = 3,
                            Discriminator = "CompositeMenu",
                            DisplayName = "技术文档",
                            Icon = "oi-document",
                            Name = "Document"
                        });
                });

            modelBuilder.Entity("IEManageSystem.CMS.DomainModel.Menus.LeafMenu", b =>
                {
                    b.HasBaseType("IEManageSystem.CMS.DomainModel.Menus.MenuBase");

                    b.HasDiscriminator().HasValue("LeafMenu");

                    b.HasData(
                        new
                        {
                            Id = 101,
                            CompositeMenuId = 2,
                            Discriminator = "LeafMenu",
                            DisplayName = "主机游戏",
                            Name = "PCGame"
                        },
                        new
                        {
                            Id = 102,
                            CompositeMenuId = 2,
                            Discriminator = "LeafMenu",
                            DisplayName = "手机游戏",
                            Name = "PhoneGame"
                        },
                        new
                        {
                            Id = 103,
                            CompositeMenuId = 3,
                            Discriminator = "LeafMenu",
                            DisplayName = "站点技术",
                            Name = "Web"
                        },
                        new
                        {
                            Id = 104,
                            CompositeMenuId = 3,
                            Discriminator = "LeafMenu",
                            DisplayName = "桌面开发",
                            Name = "Desktop"
                        });
                });

            modelBuilder.Entity("IEManageSystem.CMS.DomainModel.Pages.ContentPage", b =>
                {
                    b.HasBaseType("IEManageSystem.CMS.DomainModel.Pages.PageBase");

                    b.HasDiscriminator().HasValue("ContentPage");
                });

            modelBuilder.Entity("IEManageSystem.CMS.DomainModel.Pages.StaticPage", b =>
                {
                    b.HasBaseType("IEManageSystem.CMS.DomainModel.Pages.PageBase");

                    b.HasDiscriminator().HasValue("StaticPage");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "这是一个首页",
                            Discriminator = "StaticPage",
                            DisplayName = "首页",
                            Name = "Home"
                        });
                });

            modelBuilder.Entity("IEManageSystem.CMS.DomainModel.Pages.CompositeComponent", b =>
                {
                    b.HasBaseType("IEManageSystem.CMS.DomainModel.Pages.PageComponentBase");

                    b.HasDiscriminator().HasValue("CompositeComponent");
                });

            modelBuilder.Entity("IEManageSystem.CMS.DomainModel.Pages.LeafComponent", b =>
                {
                    b.HasBaseType("IEManageSystem.CMS.DomainModel.Pages.PageComponentBase");

                    b.HasDiscriminator().HasValue("LeafComponent");
                });

            modelBuilder.Entity("IEManageSystem.CMS.DomainModel.Pages.PageLeafComponent", b =>
                {
                    b.HasBaseType("IEManageSystem.CMS.DomainModel.Pages.PageComponentBase");

                    b.Property<int?>("TargetPageId");

                    b.HasIndex("TargetPageId");

                    b.HasDiscriminator().HasValue("PageLeafComponent");
                });

            modelBuilder.Entity("IEManageSystem.ApiAuthorization.DomainModel.ApiScopes.ApiScope", b =>
                {
                    b.HasOne("IEManageSystem.ApiAuthorization.DomainModel.ApiScopes.AuthorizationNodes.ApiScopeNode", "ApiManageScope")
                        .WithMany()
                        .HasForeignKey("ApiManageScopeId");

                    b.HasOne("IEManageSystem.ApiAuthorization.DomainModel.ApiScopes.AuthorizationNodes.ApiScopeNode", "ApiQueryScope")
                        .WithMany()
                        .HasForeignKey("ApiQueryScopeId");
                });

            modelBuilder.Entity("IEManageSystem.ApiAuthorization.DomainModel.ApiScopes.ApiScopePermission", b =>
                {
                    b.HasOne("IEManageSystem.ApiAuthorization.DomainModel.ApiScopes.AuthorizationNodes.ApiScopeNode")
                        .WithMany("ApiScopePermissions")
                        .HasForeignKey("ApiScopeNodeId");

                    b.HasOne("IEManageSystem.Entitys.Authorization.Permissions.Permission", "Permission")
                        .WithMany()
                        .HasForeignKey("PermissionId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("IEManageSystem.CMS.DomainModel.Menus.MenuBase", b =>
                {
                    b.HasOne("IEManageSystem.CMS.DomainModel.Menus.CompositeMenu")
                        .WithMany("Menus")
                        .HasForeignKey("CompositeMenuId");

                    b.HasOne("IEManageSystem.CMS.DomainModel.PageDatas.PageData", "PageData")
                        .WithMany()
                        .HasForeignKey("PageDataId");
                });

            modelBuilder.Entity("IEManageSystem.CMS.DomainModel.PageDatas.ContentComponentData", b =>
                {
                    b.HasOne("IEManageSystem.CMS.DomainModel.PageDatas.PageData", "PageData")
                        .WithMany("ContentComponentDatas")
                        .HasForeignKey("PageDataId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("IEManageSystem.CMS.DomainModel.PageDatas.PageData", b =>
                {
                    b.HasOne("IEManageSystem.CMS.DomainModel.Pages.PageBase", "Page")
                        .WithMany("PageDatas")
                        .HasForeignKey("PageId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("IEManageSystem.CMS.DomainModel.Pages.PageComponentBase", b =>
                {
                    b.HasOne("IEManageSystem.CMS.DomainModel.CmsComponent", "CmsComponent")
                        .WithMany()
                        .HasForeignKey("CmsComponentId");

                    b.HasOne("IEManageSystem.CMS.DomainModel.Pages.PageBase", "Page")
                        .WithMany("PageComponents")
                        .HasForeignKey("PageId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.OwnsOne("IEManageSystem.CMS.DomainModel.Pages.PageComponentBaseSetting", "PageComponentBaseSetting", b1 =>
                        {
                            b1.Property<int>("PageComponentBaseId")
                                .ValueGeneratedOnAdd()
                                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                            b1.Property<string>("BackgroundColor");

                            b1.Property<string>("ClassName");

                            b1.Property<string>("Col");

                            b1.Property<string>("Height");

                            b1.Property<string>("Margin");

                            b1.Property<string>("Padding");

                            b1.Property<int>("SortIndex");

                            b1.HasKey("PageComponentBaseId");

                            b1.ToTable("PageComponentBase");

                            b1.HasOne("IEManageSystem.CMS.DomainModel.Pages.PageComponentBase")
                                .WithOne("PageComponentBaseSetting")
                                .HasForeignKey("IEManageSystem.CMS.DomainModel.Pages.PageComponentBaseSetting", "PageComponentBaseId")
                                .OnDelete(DeleteBehavior.Cascade);
                        });
                });

            modelBuilder.Entity("IEManageSystem.CMS.DomainModel.Pages.PageComponentSetting", b =>
                {
                    b.HasOne("IEManageSystem.CMS.DomainModel.Pages.PageComponentBase")
                        .WithMany("PageComponentSettings")
                        .HasForeignKey("PageComponentBaseId");
                });

            modelBuilder.Entity("IEManageSystem.Entitys.Authorization.Roles.RolePermission", b =>
                {
                    b.HasOne("IEManageSystem.Entitys.Authorization.Permissions.Permission", "Permission")
                        .WithMany()
                        .HasForeignKey("PermissionId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("IEManageSystem.Entitys.Authorization.Roles.Role")
                        .WithMany("RolePermissions")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("IEManageSystem.Entitys.Authorization.Users.Accounts.Account", b =>
                {
                    b.OwnsOne("IEManageSystem.Entitys.Authorization.Users.Accounts.SafetyProblem", "SafetyProblem", b1 =>
                        {
                            b1.Property<int>("AccountId")
                                .ValueGeneratedOnAdd()
                                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                            b1.Property<string>("Answer")
                                .HasMaxLength(20);

                            b1.Property<string>("Problem")
                                .HasMaxLength(20);

                            b1.HasKey("AccountId");

                            b1.ToTable("Account");

                            b1.HasOne("IEManageSystem.Entitys.Authorization.Users.Accounts.Account")
                                .WithOne("SafetyProblem")
                                .HasForeignKey("IEManageSystem.Entitys.Authorization.Users.Accounts.SafetyProblem", "AccountId")
                                .OnDelete(DeleteBehavior.Cascade);
                        });
                });

            modelBuilder.Entity("IEManageSystem.Entitys.Authorization.Users.User", b =>
                {
                    b.HasOne("IEManageSystem.Entitys.Authorization.Users.Accounts.Account", "Account")
                        .WithMany()
                        .HasForeignKey("AccountId");
                });

            modelBuilder.Entity("IEManageSystem.Entitys.Authorization.Users.UserRole", b =>
                {
                    b.HasOne("IEManageSystem.Entitys.Authorization.Roles.Role", "Role")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("IEManageSystem.Entitys.Authorization.Users.User")
                        .WithMany("UserRoles")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("IEManageSystem.CMS.DomainModel.Pages.PageLeafComponent", b =>
                {
                    b.HasOne("IEManageSystem.CMS.DomainModel.Pages.PageBase", "TargetPage")
                        .WithMany()
                        .HasForeignKey("TargetPageId");
                });
#pragma warning restore 612, 618
        }
    }
}
