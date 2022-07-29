﻿// <auto-generated />
using System;
using LocadoraDeVeiculos.ORM.Compartilhado;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace LocadoraDeVeiculos.ORM.Migrations
{
    [DbContext(typeof(LocadoraDeVeiculosDbContext))]
    partial class LocadoraDeVeiculosDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Funcionario", b =>
                {
                    b.Property<Guid>("ID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("Admin")
                        .HasColumnType("bit");

                    b.Property<DateTime>("DataAdmissao")
                        .HasColumnType("datetime2");

                    b.Property<string>("Login")
                        .IsRequired()
                        .HasColumnType("varchar(300)");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("varchar(300)");

                    b.Property<float>("Salario")
                        .HasColumnType("real");

                    b.Property<string>("Senha")
                        .IsRequired()
                        .HasColumnType("varchar(300)");

                    b.HasKey("ID");

                    b.ToTable("FUNCIONARIO", (string)null);
                });

            modelBuilder.Entity("LocadoraDeVeiculos.Dominio.ModuloCliente.Cliente", b =>
                {
                    b.Property<Guid>("ID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("CNPJ")
                        .IsRequired()
                        .HasColumnType("varchar(300)");

                    b.Property<string>("CPF")
                        .IsRequired()
                        .HasColumnType("varchar(300)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("varchar(300)");

                    b.Property<string>("Endereco")
                        .IsRequired()
                        .HasColumnType("varchar(300)");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("varchar(300)");

                    b.Property<bool>("PessoaFisica")
                        .HasColumnType("bit");

                    b.Property<string>("Telefone")
                        .IsRequired()
                        .HasColumnType("varchar(300)");

                    b.HasKey("ID");

                    b.ToTable("CLIENTE", (string)null);
                });

            modelBuilder.Entity("LocadoraDeVeiculos.Dominio.ModuloCondutor.Condutor", b =>
                {
                    b.Property<Guid>("ID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("CNH")
                        .IsRequired()
                        .HasColumnType("varchar(300)");

                    b.Property<string>("CPF")
                        .IsRequired()
                        .HasColumnType("varchar(300)");

                    b.Property<Guid>("ClienteID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("CondutorCliente")
                        .HasColumnType("bit");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("varchar(300)");

                    b.Property<string>("Endereco")
                        .IsRequired()
                        .HasColumnType("varchar(300)");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("varchar(300)");

                    b.Property<string>("Telefone")
                        .IsRequired()
                        .HasColumnType("varchar(300)");

                    b.Property<DateTime>("ValidadeCNH")
                        .HasColumnType("datetime2");

                    b.HasKey("ID");

                    b.HasIndex("ClienteID");

                    b.ToTable("CONDUTOR", (string)null);
                });

            modelBuilder.Entity("LocadoraDeVeiculos.Dominio.ModuloGrupoDeVeiculo.GrupoDeVeiculo", b =>
                {
                    b.Property<Guid>("ID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("varchar(300)");

                    b.HasKey("ID");

                    b.ToTable("GRUPODEVEICULOS", (string)null);
                });

            modelBuilder.Entity("LocadoraDeVeiculos.Dominio.ModuloLocacao.Locacao", b =>
                {
                    b.Property<Guid>("ID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("ClienteID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("CondutorID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("DataDevolucao")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DataLocacao")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("FuncionarioID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("PlanoID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Seguro")
                        .IsRequired()
                        .HasColumnType("varchar(300)");

                    b.Property<string>("StatusLocacao")
                        .IsRequired()
                        .HasColumnType("varchar(300)");

                    b.Property<double>("Valor")
                        .HasColumnType("float");

                    b.Property<Guid>("VeiculoID")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("ID");

                    b.HasIndex("ClienteID");

                    b.HasIndex("CondutorID");

                    b.HasIndex("FuncionarioID");

                    b.HasIndex("PlanoID");

                    b.HasIndex("VeiculoID");

                    b.ToTable("LOCACAO", (string)null);
                });

            modelBuilder.Entity("LocadoraDeVeiculos.Dominio.ModuloPlanoDeCobranca.PlanoDeCobranca", b =>
                {
                    b.Property<Guid>("ID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<double>("ControladoLimiteKM")
                        .HasColumnType("float");

                    b.Property<double>("ControladoValorDia")
                        .HasColumnType("float");

                    b.Property<double>("ControladoValorKM")
                        .HasColumnType("float");

                    b.Property<double>("DiarioValorDia")
                        .HasColumnType("float");

                    b.Property<double>("DiarioValorKM")
                        .HasColumnType("float");

                    b.Property<Guid>("GrupoDeVeiculosID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<double>("LivreValorDia")
                        .HasColumnType("float");

                    b.HasKey("ID");

                    b.HasIndex("GrupoDeVeiculosID");

                    b.ToTable("PLANODECOBRANCA", (string)null);
                });

            modelBuilder.Entity("LocadoraDeVeiculos.Dominio.ModuloTaxa.Taxa", b =>
                {
                    b.Property<Guid>("ID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasColumnType("varchar(300)");

                    b.Property<Guid?>("LocacaoID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Tipo")
                        .IsRequired()
                        .HasColumnType("varchar(300)");

                    b.Property<double>("Valor")
                        .HasColumnType("float");

                    b.HasKey("ID");

                    b.HasIndex("LocacaoID");

                    b.ToTable("TAXA", (string)null);
                });

            modelBuilder.Entity("LocadoraDeVeiculos.Dominio.ModuloVeiculo.Veiculo", b =>
                {
                    b.Property<Guid>("ID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Ano")
                        .HasColumnType("int");

                    b.Property<double>("CapacidadeDoTanque")
                        .HasColumnType("float");

                    b.Property<string>("Cor")
                        .IsRequired()
                        .HasColumnType("varchar(300)");

                    b.Property<byte[]>("Foto")
                        .IsRequired()
                        .HasColumnType("varbinary(max)");

                    b.Property<Guid>("GrupoDeVeiculoID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<double>("KmPercorrido")
                        .HasColumnType("float");

                    b.Property<string>("Marca")
                        .IsRequired()
                        .HasColumnType("varchar(300)");

                    b.Property<string>("Modelo")
                        .IsRequired()
                        .HasColumnType("varchar(300)");

                    b.Property<string>("Placa")
                        .IsRequired()
                        .HasColumnType("varchar(300)");

                    b.Property<string>("TipoCombustivel")
                        .IsRequired()
                        .HasColumnType("varchar(300)");

                    b.HasKey("ID");

                    b.HasIndex("GrupoDeVeiculoID");

                    b.ToTable("VEICULO", (string)null);
                });

            modelBuilder.Entity("LocadoraDeVeiculos.Dominio.ModuloCondutor.Condutor", b =>
                {
                    b.HasOne("LocadoraDeVeiculos.Dominio.ModuloCliente.Cliente", "Cliente")
                        .WithMany()
                        .HasForeignKey("ClienteID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Cliente");
                });

            modelBuilder.Entity("LocadoraDeVeiculos.Dominio.ModuloLocacao.Locacao", b =>
                {
                    b.HasOne("LocadoraDeVeiculos.Dominio.ModuloCliente.Cliente", "Cliente")
                        .WithMany()
                        .HasForeignKey("ClienteID")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("LocadoraDeVeiculos.Dominio.ModuloCondutor.Condutor", "Condutor")
                        .WithMany()
                        .HasForeignKey("CondutorID")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("Funcionario", "Funcionario")
                        .WithMany()
                        .HasForeignKey("FuncionarioID")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("LocadoraDeVeiculos.Dominio.ModuloPlanoDeCobranca.PlanoDeCobranca", "Plano")
                        .WithMany()
                        .HasForeignKey("PlanoID")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("LocadoraDeVeiculos.Dominio.ModuloVeiculo.Veiculo", "Veiculo")
                        .WithMany()
                        .HasForeignKey("VeiculoID")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("Cliente");

                    b.Navigation("Condutor");

                    b.Navigation("Funcionario");

                    b.Navigation("Plano");

                    b.Navigation("Veiculo");
                });

            modelBuilder.Entity("LocadoraDeVeiculos.Dominio.ModuloPlanoDeCobranca.PlanoDeCobranca", b =>
                {
                    b.HasOne("LocadoraDeVeiculos.Dominio.ModuloGrupoDeVeiculo.GrupoDeVeiculo", "GrupoDeVeiculos")
                        .WithMany()
                        .HasForeignKey("GrupoDeVeiculosID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("GrupoDeVeiculos");
                });

            modelBuilder.Entity("LocadoraDeVeiculos.Dominio.ModuloTaxa.Taxa", b =>
                {
                    b.HasOne("LocadoraDeVeiculos.Dominio.ModuloLocacao.Locacao", null)
                        .WithMany("Taxas")
                        .HasForeignKey("LocacaoID");
                });

            modelBuilder.Entity("LocadoraDeVeiculos.Dominio.ModuloVeiculo.Veiculo", b =>
                {
                    b.HasOne("LocadoraDeVeiculos.Dominio.ModuloGrupoDeVeiculo.GrupoDeVeiculo", "GrupoDeVeiculo")
                        .WithMany()
                        .HasForeignKey("GrupoDeVeiculoID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("GrupoDeVeiculo");
                });

            modelBuilder.Entity("LocadoraDeVeiculos.Dominio.ModuloLocacao.Locacao", b =>
                {
                    b.Navigation("Taxas");
                });
#pragma warning restore 612, 618
        }
    }
}
