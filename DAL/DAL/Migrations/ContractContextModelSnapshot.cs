﻿// <auto-generated />
using System;
using DAL;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace DAL.Migrations
{
    [DbContext(typeof(ContractContext))]
    partial class ContractContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.3")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("DAL.ModelsDAL.Area", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("FullName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SimpleName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Areas");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            FullName = "Гомельская область",
                            SimpleName = "Гомель обл"
                        },
                        new
                        {
                            Id = 2,
                            FullName = "Мозырский район",
                            SimpleName = "Мозырь"
                        },
                        new
                        {
                            Id = 3,
                            FullName = "Наровлянский район",
                            SimpleName = "Наровля"
                        },
                        new
                        {
                            Id = 4,
                            FullName = "город Минск",
                            SimpleName = "Минск"
                        });
                });

            modelBuilder.Entity("DAL.ModelsDAL.Contract", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime?>("EndDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Number")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("OrganizationId")
                        .HasColumnType("int");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("OrganizationId");

                    b.ToTable("Contracts");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            EndDate = new DateTime(2021, 3, 9, 20, 14, 11, 355, DateTimeKind.Local).AddTicks(909),
                            Number = "12-123/ВК6",
                            OrganizationId = 1,
                            StartDate = new DateTime(2021, 3, 9, 20, 14, 11, 353, DateTimeKind.Local).AddTicks(6706)
                        },
                        new
                        {
                            Id = 2,
                            EndDate = new DateTime(2021, 3, 9, 20, 14, 11, 355, DateTimeKind.Local).AddTicks(2135),
                            Number = "12-1/ГК6",
                            OrganizationId = 2,
                            StartDate = new DateTime(2021, 3, 9, 20, 14, 11, 355, DateTimeKind.Local).AddTicks(2121)
                        },
                        new
                        {
                            Id = 3,
                            EndDate = new DateTime(2021, 3, 9, 20, 14, 11, 355, DateTimeKind.Local).AddTicks(2151),
                            Number = "33-4/НК-6",
                            OrganizationId = 3,
                            StartDate = new DateTime(2021, 3, 9, 20, 14, 11, 355, DateTimeKind.Local).AddTicks(2149)
                        },
                        new
                        {
                            Id = 4,
                            EndDate = new DateTime(2021, 3, 9, 20, 14, 11, 355, DateTimeKind.Local).AddTicks(2155),
                            Number = "4484/ОИ-6",
                            OrganizationId = 4,
                            StartDate = new DateTime(2021, 3, 9, 20, 14, 11, 355, DateTimeKind.Local).AddTicks(2153)
                        });
                });

            modelBuilder.Entity("DAL.ModelsDAL.Organization", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("AreaId")
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FullName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Smdo")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("AreaId");

                    b.ToTable("Organizations");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Address = "ул Ленина 18",
                            AreaId = 1,
                            Email = "GomelOblFu@gomel.by",
                            FullName = "Областное финансовое упрвление",
                            Name = "Обл ФУ",
                            Smdo = "Org1235"
                        },
                        new
                        {
                            Id = 2,
                            Address = "д. Лесовики 3",
                            AreaId = 2,
                            Email = "NPZ@npz.by",
                            FullName = "Мозырский нефтеперерабатывающий завод",
                            Name = "НПЗ",
                            Smdo = "Org48693"
                        },
                        new
                        {
                            Id = 3,
                            Address = "ул фабричная 1",
                            AreaId = 3,
                            Email = "Korovka@korovka.by",
                            FullName = "ОАО Красный Мозырянин",
                            Name = "Красный мозырянин"
                        },
                        new
                        {
                            Id = 4,
                            Address = "ул Коммунистическая 4",
                            AreaId = 3,
                            Email = "Narovlya@roo.gomel.by",
                            FullName = "Районный отдел образования",
                            Name = "Роо"
                        },
                        new
                        {
                            Id = 5,
                            Address = "ул Заводская 85/4",
                            AreaId = 4,
                            Email = "Keramin@keramin.by",
                            FullName = "ЗАО Керамин",
                            Name = "Керамин"
                        });
                });

            modelBuilder.Entity("DAL.ModelsDAL.Person", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MiddleName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MobilePhone")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("OrganizationId")
                        .HasColumnType("int");

                    b.Property<string>("Phone")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Position")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("OrganizationId");

                    b.ToTable("People");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Email = "KovalchukAV@gomel.by",
                            FirstName = "Алёна",
                            LastName = "Ковальчук",
                            MiddleName = "Витальевна",
                            OrganizationId = 1,
                            Phone = "80232-23-56-84",
                            Position = "Главный экономист"
                        },
                        new
                        {
                            Id = 2,
                            Email = "PesokovVI@npz.by",
                            FirstName = "Валерий",
                            LastName = "Песоков",
                            MiddleName = "Игнатьевич",
                            OrganizationId = 2,
                            Phone = "80236-34-52-68",
                            Position = "Главный специалист"
                        },
                        new
                        {
                            Id = 3,
                            FirstName = "Василий",
                            LastName = "Фонрос",
                            MiddleName = "Иванович",
                            OrganizationId = 3,
                            Phone = "802355-4-58-22"
                        },
                        new
                        {
                            Id = 4,
                            FirstName = "Анастасия",
                            LastName = "Катонова",
                            MiddleName = "Васильвна",
                            OrganizationId = 4,
                            Phone = "802355-4-26-84",
                            Position = "Главный бухгалтер"
                        },
                        new
                        {
                            Id = 5,
                            Email = "BulbaII@keramin.by",
                            FirstName = "Ирина",
                            LastName = "Бульба",
                            MiddleName = "Игнатьевна",
                            OrganizationId = 5,
                            Phone = "8017-45-78-32"
                        });
                });

            modelBuilder.Entity("DAL.ModelsDAL.Serivces.ServiceHardware", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ContractId")
                        .HasColumnType("int");

                    b.Property<int>("ServerCount")
                        .HasColumnType("int");

                    b.Property<int>("ServiceInfoId")
                        .HasColumnType("int");

                    b.Property<int>("WorkplaceCount")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ContractId");

                    b.HasIndex("ServiceInfoId");

                    b.ToTable("ServiceHardwares");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            ContractId = 1,
                            ServerCount = 0,
                            ServiceInfoId = 3,
                            WorkplaceCount = 2
                        },
                        new
                        {
                            Id = 2,
                            ContractId = 2,
                            ServerCount = 0,
                            ServiceInfoId = 4,
                            WorkplaceCount = 5
                        },
                        new
                        {
                            Id = 3,
                            ContractId = 4,
                            ServerCount = 1,
                            ServiceInfoId = 3,
                            WorkplaceCount = 5
                        },
                        new
                        {
                            Id = 4,
                            ContractId = 3,
                            ServerCount = 1,
                            ServiceInfoId = 4,
                            WorkplaceCount = 2
                        });
                });

            modelBuilder.Entity("DAL.ModelsDAL.Serivces.ServiceInfo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<double>("AdditionalCost")
                        .HasColumnType("float");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("MainCost")
                        .HasColumnType("float");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("ServiceInfo");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            AdditionalCost = 15.300000000000001,
                            Description = "Консультации, удалённая поддержка. При необходимости выезд к клиенту",
                            MainCost = 23.5,
                            Name = "Обслуживание КлиентТК"
                        },
                        new
                        {
                            Id = 2,
                            AdditionalCost = 14.199999999999999,
                            Description = "Установкаю, консультации, удалённая поддержка. При необходимости выезд к клиенту.",
                            MainCost = 19.300000000000001,
                            Name = "Обслуживание ГРС"
                        },
                        new
                        {
                            Id = 3,
                            AdditionalCost = 26.300000000000001,
                            Description = "Обслуживание техники. Ежемесечная проверка с диагностикой на месте эксплуатации.",
                            MainCost = 32.159999999999997,
                            Name = "Сопровождение вычислительно техники"
                        },
                        new
                        {
                            Id = 4,
                            AdditionalCost = 21.600000000000001,
                            Description = "Удалённое бслуживание техники без выезда на место",
                            MainCost = 25.859999999999999,
                            Name = "Удалённое сопровождение вычислительно техники"
                        });
                });

            modelBuilder.Entity("DAL.ModelsDAL.Serivces.ServiceSoftware", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AdditionalPlaceCount")
                        .HasColumnType("int");

                    b.Property<int>("ContractId")
                        .HasColumnType("int");

                    b.Property<int>("MainPlaceCount")
                        .HasColumnType("int");

                    b.Property<int>("ServiceInfoId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ContractId");

                    b.HasIndex("ServiceInfoId");

                    b.ToTable("ServiceSoftwares");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            AdditionalPlaceCount = 0,
                            ContractId = 1,
                            MainPlaceCount = 1,
                            ServiceInfoId = 1
                        },
                        new
                        {
                            Id = 2,
                            AdditionalPlaceCount = 0,
                            ContractId = 2,
                            MainPlaceCount = 1,
                            ServiceInfoId = 2
                        },
                        new
                        {
                            Id = 3,
                            AdditionalPlaceCount = 1,
                            ContractId = 3,
                            MainPlaceCount = 1,
                            ServiceInfoId = 1
                        },
                        new
                        {
                            Id = 4,
                            AdditionalPlaceCount = 0,
                            ContractId = 4,
                            MainPlaceCount = 1,
                            ServiceInfoId = 2
                        },
                        new
                        {
                            Id = 5,
                            AdditionalPlaceCount = 1,
                            ContractId = 4,
                            MainPlaceCount = 0,
                            ServiceInfoId = 1
                        });
                });

            modelBuilder.Entity("DAL.ModelsDAL.Contract", b =>
                {
                    b.HasOne("DAL.ModelsDAL.Organization", "Organization")
                        .WithMany("Contracts")
                        .HasForeignKey("OrganizationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Organization");
                });

            modelBuilder.Entity("DAL.ModelsDAL.Organization", b =>
                {
                    b.HasOne("DAL.ModelsDAL.Area", "Area")
                        .WithMany("Organizations")
                        .HasForeignKey("AreaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Area");
                });

            modelBuilder.Entity("DAL.ModelsDAL.Person", b =>
                {
                    b.HasOne("DAL.ModelsDAL.Organization", "Organization")
                        .WithMany()
                        .HasForeignKey("OrganizationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Organization");
                });

            modelBuilder.Entity("DAL.ModelsDAL.Serivces.ServiceHardware", b =>
                {
                    b.HasOne("DAL.ModelsDAL.Contract", "Contract")
                        .WithMany("ServicesHardware")
                        .HasForeignKey("ContractId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DAL.ModelsDAL.Serivces.ServiceInfo", "ServiceInfo")
                        .WithMany()
                        .HasForeignKey("ServiceInfoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Contract");

                    b.Navigation("ServiceInfo");
                });

            modelBuilder.Entity("DAL.ModelsDAL.Serivces.ServiceSoftware", b =>
                {
                    b.HasOne("DAL.ModelsDAL.Contract", "Contract")
                        .WithMany("ServicesSoftware")
                        .HasForeignKey("ContractId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DAL.ModelsDAL.Serivces.ServiceInfo", "ServiceInfo")
                        .WithMany()
                        .HasForeignKey("ServiceInfoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Contract");

                    b.Navigation("ServiceInfo");
                });

            modelBuilder.Entity("DAL.ModelsDAL.Area", b =>
                {
                    b.Navigation("Organizations");
                });

            modelBuilder.Entity("DAL.ModelsDAL.Contract", b =>
                {
                    b.Navigation("ServicesHardware");

                    b.Navigation("ServicesSoftware");
                });

            modelBuilder.Entity("DAL.ModelsDAL.Organization", b =>
                {
                    b.Navigation("Contracts");
                });
#pragma warning restore 612, 618
        }
    }
}
