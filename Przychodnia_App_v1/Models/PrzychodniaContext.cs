using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Przychodnia_App_v1.Models;

public partial class PrzychodniaContext : DbContext
{
    public PrzychodniaContext()
    {
    }

    public PrzychodniaContext(DbContextOptions<PrzychodniaContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Adre> Adres { get; set; }

    public virtual DbSet<BadanieDodatkowe> BadanieDodatkowes { get; set; }

    public virtual DbSet<Kontum> Konta { get; set; }

    public virtual DbSet<Lekarstwo> Lekarstwos { get; set; }

    public virtual DbSet<Lekarz> Lekarzs { get; set; }

    public virtual DbSet<OpłataZaWizyte> OpłataZaWizytes { get; set; }

    public virtual DbSet<Pacjent> Pacjents { get; set; }

    public virtual DbSet<Receptum> Recepta { get; set; }

    public virtual DbSet<Skierowanie> Skierowanies { get; set; }

    public virtual DbSet<SzczegółyBadań> SzczegółyBadańs { get; set; }

    public virtual DbSet<SzczegółyRecepty> SzczegółyRecepties { get; set; }

    public virtual DbSet<Wizyty> Wizyties { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=localhost;Initial Catalog=Przychodnia;Integrated Security=True; Encrypt=True;TrustServerCertificate=True;Connection Timeout=60;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.UseCollation("Polish_CI_AS");

        modelBuilder.Entity<Adre>(entity =>
        {
            entity.HasKey(e => e.IdAdresu).HasName("Adres_PK");

            entity.HasIndex(e => e.IdAdresu, "Adres__IDX").IsUnique();

            entity.Property(e => e.IdAdresu).HasColumnName("id_adresu");
            entity.Property(e => e.KodPocztowy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("kod_pocztowy");
            entity.Property(e => e.Miasto)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("miasto");
            entity.Property(e => e.NrMieszkania)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("nr_mieszkania");
            entity.Property(e => e.Ulica)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ulica");
        });

        modelBuilder.Entity<BadanieDodatkowe>(entity =>
        {
            entity.HasKey(e => e.IdBadaniaDodatkowe).HasName("Badanie_Dodatkowe_PK");

            entity.ToTable("Badanie_Dodatkowe");

            entity.HasIndex(e => e.IdBadaniaDodatkowe, "Badanie_Dodatkowe__IDX").IsUnique();

            entity.Property(e => e.IdBadaniaDodatkowe).HasColumnName("id_badania_dodatkowe");
            entity.Property(e => e.Nazwa)
                .HasMaxLength(300)
                .IsUnicode(false)
                .HasColumnName("nazwa");
            entity.Property(e => e.Rodzaj)
                .HasMaxLength(300)
                .IsUnicode(false)
                .HasColumnName("rodzaj");
        });

        modelBuilder.Entity<Kontum>(entity =>
        {
            entity.HasKey(e => e.IdKonta).HasName("PK__Konta__FC8E0B9BC4C1B6A1");

            entity.Property(e => e.IdKonta)
                .ValueGeneratedNever()
                .HasColumnName("id_konta");
            entity.Property(e => e.Email)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("email");
            entity.Property(e => e.Haslo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Imie)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Login)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Nazwisko)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Lekarstwo>(entity =>
        {
            entity.HasKey(e => e.IdLekarstwa).HasName("Lekarstwo_PK");

            entity.ToTable("Lekarstwo");

            entity.HasIndex(e => e.IdLekarstwa, "Lekarstwo__IDX").IsUnique();

            entity.Property(e => e.IdLekarstwa).HasColumnName("id_lekarstwa");
            entity.Property(e => e.Nazwa)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("nazwa");
            entity.Property(e => e.Producent)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("producent");
            entity.Property(e => e.Rodzaj)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("rodzaj");
        });

        modelBuilder.Entity<Lekarz>(entity =>
        {
            entity.HasKey(e => e.IdLekarza).HasName("Lekarz_PK");

            entity.ToTable("Lekarz");

            entity.HasIndex(e => e.IdLekarza, "Lekarz__IDX").IsUnique();

            entity.Property(e => e.IdLekarza).HasColumnName("id_lekarza");
            entity.Property(e => e.Imie)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Nazwisko)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Specjalizacja)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<OpłataZaWizyte>(entity =>
        {
            entity.HasKey(e => e.IdOpłaty).HasName("Opłata_za_wizyte_PK");

            entity.ToTable("Opłata_za_wizyte");

            entity.HasIndex(e => e.IdOpłaty, "Opłata_za_wizyte__IDX");

            entity.Property(e => e.IdOpłaty).HasColumnName("id_opłaty");
            entity.Property(e => e.IdWizyty).HasColumnName("id_wizyty");
            entity.Property(e => e.Kwota)
                .HasColumnType("money")
                .HasColumnName("kwota");
            entity.Property(e => e.Ubezpieczenie).HasColumnName("ubezpieczenie");

            entity.HasOne(d => d.IdWizytyNavigation).WithMany(p => p.OpłataZaWizytes)
                .HasForeignKey(d => d.IdWizyty)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("Opłata_za_wizyte_Wizyty_FK");
        });

        modelBuilder.Entity<Pacjent>(entity =>
        {
            entity.HasKey(e => e.IdPacjenta).HasName("Pacjent_PK");

            entity.ToTable("Pacjent");

            entity.HasIndex(e => e.IdPacjenta, "Pacjent__IDX").IsUnique();

            entity.Property(e => e.IdPacjenta).HasColumnName("id_pacjenta");
            entity.Property(e => e.Email)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("email");
            entity.Property(e => e.IdAdresu).HasColumnName("id_adresu");
            entity.Property(e => e.Imie)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Nazwisko)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.NumerTelefonu)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("Numer_telefonu");
            entity.Property(e => e.Pesel)
                .HasMaxLength(11)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("PESEL");

            entity.HasOne(d => d.IdAdresuNavigation).WithMany(p => p.Pacjents)
                .HasForeignKey(d => d.IdAdresu)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("Pacjent_Adres_FK");
        });

        modelBuilder.Entity<Receptum>(entity =>
        {
            entity.HasKey(e => e.IdRecepty).HasName("Recepta_PK");

            entity.HasIndex(e => e.IdRecepty, "Recepta__IDXv1").IsUnique();

            entity.Property(e => e.IdRecepty).HasColumnName("id_recepty");
            entity.Property(e => e.IdWizyty).HasColumnName("id_wizyty");
            entity.Property(e => e.Refundacja)
                .HasColumnType("numeric(28, 3)")
                .HasColumnName("refundacja");

            entity.HasOne(d => d.IdWizytyNavigation).WithMany(p => p.Recepta)
                .HasForeignKey(d => d.IdWizyty)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("Recepta_Wizyty_FK");
        });

        modelBuilder.Entity<Skierowanie>(entity =>
        {
            entity.HasKey(e => e.IdSkierowania).HasName("Skierowanie_PK");

            entity.ToTable("Skierowanie");

            entity.HasIndex(e => e.IdSkierowania, "Skierowanie__IDX").IsUnique();

            entity.Property(e => e.IdSkierowania).HasColumnName("id_skierowania");
            entity.Property(e => e.IdWizyty).HasColumnName("id_wizyty");
            entity.Property(e => e.Oddział)
                .HasMaxLength(300)
                .IsUnicode(false)
                .HasColumnName("oddział");
            entity.Property(e => e.Specjalista)
                .HasMaxLength(300)
                .IsUnicode(false)
                .HasColumnName("specjalista");

            entity.HasOne(d => d.IdWizytyNavigation).WithMany(p => p.Skierowanies)
                .HasForeignKey(d => d.IdWizyty)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("Skierowanie_Wizyty_FK");
        });

        modelBuilder.Entity<SzczegółyBadań>(entity =>
        {
            entity.HasKey(e => e.IdSzegółówBadań).HasName("Szczegóły_badań_PK");

            entity.ToTable("Szczegóły_badań");

            entity.HasIndex(e => e.IdSzegółówBadań, "Szczegóły_badań__IDX").IsUnique();

            entity.Property(e => e.IdSzegółówBadań).HasColumnName("id_szegółów_badań");
            entity.Property(e => e.IdBadaniaDodatkowe).HasColumnName("id_badania_dodatkowe");
            entity.Property(e => e.IdWizyty).HasColumnName("id_wizyty");
            entity.Property(e => e.Wynik)
                .IsUnicode(false)
                .HasColumnName("wynik");

            entity.HasOne(d => d.IdBadaniaDodatkoweNavigation).WithMany(p => p.SzczegółyBadańs)
                .HasForeignKey(d => d.IdBadaniaDodatkowe)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("Badanie_Dodatkowe_FK");

            entity.HasOne(d => d.IdWizytyNavigation).WithMany(p => p.SzczegółyBadańs)
                .HasForeignKey(d => d.IdWizyty)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("Szczegóły_badań_Wizyty_FK");
        });

        modelBuilder.Entity<SzczegółyRecepty>(entity =>
        {
            entity.HasKey(e => e.IdSzczegółówRecepty).HasName("Szczegóły_recepty_PK");

            entity.ToTable("Szczegóły_recepty");

            entity.HasIndex(e => e.IdSzczegółówRecepty, "Szczegóły_recepty__IDX").IsUnique();

            entity.Property(e => e.IdSzczegółówRecepty).HasColumnName("id_szczegółów_recepty");
            entity.Property(e => e.Dawkowanie)
                .HasMaxLength(300)
                .IsUnicode(false)
                .HasColumnName("dawkowanie");
            entity.Property(e => e.IdLekarstwa).HasColumnName("id_lekarstwa");
            entity.Property(e => e.IdRecepty).HasColumnName("id_recepty");

            entity.HasOne(d => d.IdLekarstwaNavigation).WithMany(p => p.SzczegółyRecepties)
                .HasForeignKey(d => d.IdLekarstwa)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("Szczegóły_recepty_Lekarstwo_FK");

            entity.HasOne(d => d.IdReceptyNavigation).WithMany(p => p.SzczegółyRecepties)
                .HasForeignKey(d => d.IdRecepty)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("Szczegóły_recepty_Recepta_FK");
        });

        modelBuilder.Entity<Wizyty>(entity =>
        {
            entity.HasKey(e => e.IdWizyty).HasName("Wizyty_PK");

            entity.ToTable("Wizyty");

            entity.HasIndex(e => e.IdWizyty, "Wizyty__IDX").IsUnique();

            entity.Property(e => e.IdWizyty).HasColumnName("id_wizyty");
            entity.Property(e => e.BadaniePrzedmiotowe)
                .IsUnicode(false)
                .HasColumnName("badanie_przedmiotowe");
            entity.Property(e => e.Data)
                .HasColumnType("date")
                .HasColumnName("data");
            entity.Property(e => e.Godzina).HasColumnName("godzina");
            entity.Property(e => e.IdLekarza).HasColumnName("id_lekarza");
            entity.Property(e => e.IdPacjenta).HasColumnName("id_pacjenta");
            entity.Property(e => e.WywiadLekarski)
                .IsUnicode(false)
                .HasColumnName("wywiad_lekarski");
            entity.Property(e => e.Zalecenia)
                .IsUnicode(false)
                .HasColumnName("zalecenia");

            entity.HasOne(d => d.IdLekarzaNavigation).WithMany(p => p.Wizyties)
                .HasForeignKey(d => d.IdLekarza)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("Wizyty_Lekarz_FK");

            entity.HasOne(d => d.IdPacjentaNavigation).WithMany(p => p.Wizyties)
                .HasForeignKey(d => d.IdPacjenta)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("Wizyty_Pacjent_FK");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
