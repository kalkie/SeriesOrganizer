using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Xml.Serialization;

namespace Chalk.SubtitlesManagement
{
   [XmlRoot(ElementName = "bierdopje", Namespace = "")]
   [Serializable()]
   public class TvShowResult : ITvShow
   {
      [XmlElement(ElementName = "response")]
      public TvShow tvShow;

      public TvShowBase TvShow
      {
         get { return tvShow; }
      }
   }

   public interface ITvShow
   {
      TvShowBase TvShow { get; }
   }

   [XmlRoot(ElementName = "bierdopje", Namespace = "")]
   [Serializable()]
   public class TvShowResultCached : ITvShow
   {
      [XmlElement(ElementName = "response")]
      public TvShowCached tvShow;

      public TvShowBase TvShow
      {
         get { return tvShow; }
      }
   }

   [Serializable()]
   public class TvShow : TvShowBase
   {
      [XmlArray("genres")]
      [XmlArrayItem("genre")]
      public List<string> genres;

      public override List<string> Genres
      {
         get
         {
            return genres;
         }
         set
         {
            base.Genres = value;
         }
      }
   }
}