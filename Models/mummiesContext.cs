using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace INTEXAPP2.Models
{
    public partial class mummiesContext : DbContext
    {
        public mummiesContext()
        {
        }

        public mummiesContext(DbContextOptions<mummiesContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Analysis> Analyses { get; set; }
        public virtual DbSet<AnalysisTextile> AnalysisTextiles { get; set; }
        public virtual DbSet<Artifactfagelgamousregister> Artifactfagelgamousregisters { get; set; }
        public virtual DbSet<ArtifactfagelgamousregisterBurialmain> ArtifactfagelgamousregisterBurialmains { get; set; }
        public virtual DbSet<Artifactkomaushimregister> Artifactkomaushimregisters { get; set; }
        public virtual DbSet<ArtifactkomaushimregisterBurialmain> ArtifactkomaushimregisterBurialmains { get; set; }
        public virtual DbSet<Biological> Biologicals { get; set; }
        public virtual DbSet<BiologicalC14> BiologicalC14s { get; set; }
        public virtual DbSet<Bodyanalysischart> Bodyanalysischarts { get; set; }
        public virtual DbSet<Book> Books { get; set; }
        public virtual DbSet<Burialmain> Burialmains { get; set; }
        public virtual DbSet<BurialmainBiological> BurialmainBiologicals { get; set; }
        public virtual DbSet<BurialmainBodyanalysischart> BurialmainBodyanalysischarts { get; set; }
        public virtual DbSet<BurialmainCranium> BurialmainCrania { get; set; }
        public virtual DbSet<BurialmainTextile> BurialmainTextiles { get; set; }
        public virtual DbSet<C14> C14s { get; set; }
        public virtual DbSet<Color> Colors { get; set; }
        public virtual DbSet<ColorTextile> ColorTextiles { get; set; }
        public virtual DbSet<Cranium> Crania { get; set; }
        public virtual DbSet<Decoration> Decorations { get; set; }
        public virtual DbSet<DecorationTextile> DecorationTextiles { get; set; }
        public virtual DbSet<Dimension> Dimensions { get; set; }
        public virtual DbSet<DimensionTextile> DimensionTextiles { get; set; }
        public virtual DbSet<Newsarticle> Newsarticles { get; set; }
        public virtual DbSet<PhotodataTextile> PhotodataTextiles { get; set; }
        public virtual DbSet<Photodatum> Photodata { get; set; }
        public virtual DbSet<Photoform> Photoforms { get; set; }
        public virtual DbSet<Structure> Structures { get; set; }
        public virtual DbSet<StructureTextile> StructureTextiles { get; set; }
        public virtual DbSet<Teammember> Teammembers { get; set; }
        public virtual DbSet<Textile> Textiles { get; set; }
        public virtual DbSet<Textilefunction> Textilefunctions { get; set; }
        public virtual DbSet<TextilefunctionTextile> TextilefunctionTextiles { get; set; }
        public virtual DbSet<Yarnmanipulation> Yarnmanipulations { get; set; }
        public virtual DbSet<YarnmanipulationTextile> YarnmanipulationTextiles { get; set; }
    }
}
