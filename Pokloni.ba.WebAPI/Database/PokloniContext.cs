using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Pokloni.ba.WebAPI.Database
{
    public partial class PokloniContext : DbContext
{
    public PokloniContext()
    {
    }

    public PokloniContext(DbContextOptions<PokloniContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Dostava> Dostava { get; set; }
    public virtual DbSet<Kategorija> Kategorija { get; set; }
    public virtual DbSet<Korisnik> Korisnik { get; set; }
    public virtual DbSet<KorisnikDetails> KorisnikDetails { get; set; }
    public virtual DbSet<Narudzba> Narudzba { get; set; }
    public virtual DbSet<NarudzbaDetails> NarudzbaDetails { get; set; }
    public virtual DbSet<Ocjena> Ocjena { get; set; }
    public virtual DbSet<Proizvod> Proizvod { get; set; }
    public virtual DbSet<ProizvodacPoklona> ProizvodacPoklona { get; set; }
    public virtual DbSet<Racun> Racun { get; set; }
    public virtual DbSet<Uloga> Uloga { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        if (!optionsBuilder.IsConfigured)
        {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
            optionsBuilder.UseSqlServer("Server=.\\;Database=Pokloni;Trusted_Connection=True;");
        }
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.HasAnnotation("ProductVersion", "2.2.6-servicing-10079");

        modelBuilder.Entity<Dostava>(entity =>
        {
            entity.Property(e => e.DostavaId).HasColumnName("DostavaID");

            entity.Property(e => e.AdresaDostave)
                .IsRequired()
                .HasMaxLength(100);

            entity.Property(e => e.DatumPreuzimanja).HasColumnType("datetime");

            entity.Property(e => e.DatumSlanja).HasColumnType("datetime");

            entity.Property(e => e.DostavljacId).HasColumnName("DostavljacID");

            entity.Property(e => e.DrzavaDostave)
                .IsRequired()
                .HasMaxLength(50);

            entity.Property(e => e.GradDostave)
                .IsRequired()
                .HasMaxLength(100);

            entity.Property(e => e.KontaktTelefon).HasMaxLength(50);

            entity.Property(e => e.PostalCode)
                .IsRequired()
                .HasMaxLength(20);

            entity.HasOne(d => d.Dostavljac)
                .WithMany(p => p.Dostava)
                .HasForeignKey(d => d.DostavljacId)
                .HasConstraintName("FK__Dostava__Dostavl__4CA06362");
        });

        modelBuilder.Entity<Kategorija>(entity =>
        {
            entity.Property(e => e.KategorijaId).HasColumnName("KategorijaID");

            entity.Property(e => e.Naziv)
                .IsRequired()
                .HasMaxLength(100);

            entity.Property(e => e.Opis)
                .IsRequired()
                .HasMaxLength(500);
        });

        modelBuilder.Entity<Korisnik>(entity =>
        {
            entity.HasIndex(e => e.Email)
                .HasName("CS_EmailUposlenik")
                .IsUnique();

            entity.Property(e => e.KorisnikId).HasColumnName("KorisnikID");

            entity.Property(e => e.DatumZadnjegLogiranja).HasColumnType("datetime");

            entity.Property(e => e.Email)
                .IsRequired()
                .HasMaxLength(50);

            entity.Property(e => e.KorisnikDetailsId).HasColumnName("KorisnikDetailsID");

            entity.Property(e => e.LozinkaHash).HasMaxLength(100);

            entity.Property(e => e.LozinkaSalt).HasMaxLength(100);

            entity.Property(e => e.UlogaId).HasColumnName("UlogaID");

            entity.Property(e => e.Username)
                .IsRequired()
                .HasMaxLength(50);

            entity.HasOne(d => d.KorisnikDetails)
                .WithMany(p => p.Korisnik)
                .HasForeignKey(d => d.KorisnikDetailsId)
                .HasConstraintName("FK__Korisnik__Korisn__3C69FB99");

            entity.HasOne(d => d.Uloga)
                .WithMany(p => p.Korisnik)
                .HasForeignKey(d => d.UlogaId)
                .HasConstraintName("FK__Korisnik__UlogaI__3D5E1FD2");
        });

        modelBuilder.Entity<KorisnikDetails>(entity =>
        {
            entity.Property(e => e.KorisnikDetailsId).HasColumnName("KorisnikDetailsID");

            entity.Property(e => e.AdresaStanovanja).HasMaxLength(300);

            entity.Property(e => e.BrojTelefona).HasMaxLength(50);

            entity.Property(e => e.DrzavaStanovanja).HasMaxLength(50);

            entity.Property(e => e.GradStanovanja).HasMaxLength(100);

            entity.Property(e => e.Ime).HasMaxLength(100);

            entity.Property(e => e.PostalCode).HasMaxLength(20);

            entity.Property(e => e.Prezime).HasMaxLength(100);
        });

        modelBuilder.Entity<Narudzba>(entity =>
        {
            entity.Property(e => e.NarudzbaId).HasColumnName("NarudzbaID");

            entity.Property(e => e.DatumNarudzbe).HasColumnType("datetime");

            entity.Property(e => e.DostavaId).HasColumnName("DostavaID");

            entity.Property(e => e.KorisnikId).HasColumnName("KorisnikID");

            entity.Property(e => e.StatusPoruka).HasMaxLength(100);

            entity.Property(e => e.ZaposlenikId).HasColumnName("ZaposlenikID");

            entity.HasOne(d => d.Dostava)
                .WithMany(p => p.Narudzba)
                .HasForeignKey(d => d.DostavaId)
                .HasConstraintName("FK__Narudzba__Dostav__5165187F");

            entity.HasOne(d => d.Korisnik)
                .WithMany(p => p.NarudzbaKorisnik)
                .HasForeignKey(d => d.KorisnikId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Narudzba__Korisn__4F7CD00D");

            entity.HasOne(d => d.Zaposlenik)
                .WithMany(p => p.NarudzbaZaposlenik)
                .HasForeignKey(d => d.ZaposlenikId)
                .HasConstraintName("FK__Narudzba__Zaposl__5070F446");
        });

        modelBuilder.Entity<NarudzbaDetails>(entity =>
        {
            entity.Property(e => e.NarudzbaDetailsId).HasColumnName("NarudzbaDetailsID");

            entity.Property(e => e.Kolicina).HasDefaultValueSql("((1))");

            entity.Property(e => e.NarudzbaId).HasColumnName("NarudzbaID");

            entity.Property(e => e.Popust)
                .HasColumnType("decimal(18, 0)")
                .HasDefaultValueSql("((0))");

            entity.Property(e => e.ProizvodId).HasColumnName("ProizvodID");

            entity.Property(e => e.Ukupno).HasColumnType("decimal(18, 0)");

            entity.HasOne(d => d.Narudzba)
                .WithMany(p => p.NarudzbaDetails)
                .HasForeignKey(d => d.NarudzbaId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__NarudzbaD__Narud__5441852A");

            entity.HasOne(d => d.Proizvod)
                .WithMany(p => p.NarudzbaDetails)
                .HasForeignKey(d => d.ProizvodId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__NarudzbaD__Proiz__5535A963");
        });

        modelBuilder.Entity<Ocjena>(entity =>
        {
            entity.HasKey(e => new { e.ProizvodId, e.KorisnikId })
                .HasName("PK__Ocjena__29A3B8CE13EC5855");

            entity.Property(e => e.ProizvodId).HasColumnName("ProizvodID");

            entity.Property(e => e.KorisnikId).HasColumnName("KorisnikID");

            entity.Property(e => e.Komentar).HasMaxLength(500);

            entity.HasOne(d => d.Korisnik)
                .WithMany(p => p.Ocjena)
                .HasForeignKey(d => d.KorisnikId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Ocjena__Korisnik__49C3F6B7");

            entity.HasOne(d => d.Proizvod)
                .WithMany(p => p.Ocjena)
                .HasForeignKey(d => d.ProizvodId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Ocjena__Proizvod__48CFD27E");
        });

        modelBuilder.Entity<Proizvod>(entity =>
        {
            entity.Property(e => e.ProizvodId).HasColumnName("ProizvodID");

            entity.Property(e => e.Cijena).HasColumnType("decimal(18, 2)");

            entity.Property(e => e.KategorijaId).HasColumnName("KategorijaID");

            entity.Property(e => e.Naziv)
                .IsRequired()
                .HasMaxLength(50);

            entity.Property(e => e.Opis)
                .IsRequired()
                .HasMaxLength(1000);

            entity.Property(e => e.ProizvodacId).HasColumnName("ProizvodacID");

            entity.Property(e => e.Sifra)
                .IsRequired()
                .HasMaxLength(50);

            entity.HasOne(d => d.Kategorija)
                .WithMany(p => p.Proizvod)
                .HasForeignKey(d => d.KategorijaId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Proizvod__Katego__440B1D61");

            entity.HasOne(d => d.Proizvodac)
                .WithMany(p => p.Proizvod)
                .HasForeignKey(d => d.ProizvodacId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Proizvod__Proizv__44FF419A");
        });

        modelBuilder.Entity<ProizvodacPoklona>(entity =>
        {
            entity.Property(e => e.ProizvodacPoklonaId).HasColumnName("ProizvodacPoklonaID");

            entity.Property(e => e.Naziv)
                .IsRequired()
                .HasMaxLength(100);

            entity.Property(e => e.Opis).HasMaxLength(1000);
        });

        modelBuilder.Entity<Racun>(entity =>
        {
            entity.Property(e => e.RacunId).HasColumnName("RacunID");

            entity.Property(e => e.BrojRacuna)
                .IsRequired()
                .HasMaxLength(50);

            entity.Property(e => e.CijenaBezPdv)
                .HasColumnName("CijenaBezPDV")
                .HasColumnType("decimal(18, 2)");

            entity.Property(e => e.CijenaSaPdv)
                .HasColumnName("CijenaSaPDV")
                .HasColumnType("decimal(18, 2)");

            entity.Property(e => e.DatumIzdavanja).HasColumnType("date");

            entity.Property(e => e.NarudzbaId).HasColumnName("NarudzbaID");

            entity.Property(e => e.VrstaPlacanja).HasMaxLength(20);

            entity.HasOne(d => d.Narudzba)
                .WithMany(p => p.Racun)
                .HasForeignKey(d => d.NarudzbaId)
                .HasConstraintName("FK__Racun__NarudzbaI__59FA5E80");
        });

        modelBuilder.Entity<Uloga>(entity =>
        {
            entity.Property(e => e.UlogaId).HasColumnName("UlogaID");

            entity.Property(e => e.Naziv)
                .IsRequired()
                .HasMaxLength(50);

            entity.Property(e => e.Opis)
                .IsRequired()
                .HasMaxLength(200);
        });
    }
}
}
