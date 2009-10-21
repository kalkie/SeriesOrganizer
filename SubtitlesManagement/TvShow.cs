using System;
using System.Runtime.Serialization;
using System.Xml.Serialization;

namespace Chalk.SubtitlesManagement
{
   [XmlRoot(ElementName = "bierdopje", Namespace = "")]
   [Serializable()]
   public class BierDopje
   {
      [XmlElement(ElementName = "response")]
      public TvShow tvShow;
   }

   [Serializable()]
   public class TvShow
   {
      [XmlElement("showid")]
      public int id;

      [XmlElement("tvdbid")]
      public int tvDbId;

      [XmlElement("showname")]
      public string showName;

      [XmlElement("showlink")]
      public string showLink;

      [XmlElement("firstaired")]
      public string firstAired;

      [XmlElement("lastaired")]
      public string lastAired;

      [XmlElement("nextepisode")]
      public string nextEpisode;

      [XmlElement("seasons")]
      public int season;

      [XmlElement("episodes")]
      public int numberOfEpisodes;

      [XmlElement("genres")]
      public Genres genres;

      [XmlElement("showstatus")]
      public string showStatus;

      [XmlElement("network")]
      public string network;

      [XmlElement("airtime")]
      public string airTime;

      [XmlElement("runtime")]
      public int runTime;

      [XmlElement("score")]
      public string score;

      [XmlElement("favorites")]
      public int favorites;

      [XmlElement("has_translators")]
      public bool hasTranslators;

      [XmlElement("summary")]
      public string summary;

      [XmlElement("status")]
      public string status;

      [XmlElement("cached")]
      public bool cached;
   }
}