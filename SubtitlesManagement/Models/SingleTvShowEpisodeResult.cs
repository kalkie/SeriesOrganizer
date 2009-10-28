using System;
using System.Xml.Serialization;

namespace Chalk.SubtitlesManagement
{
   [XmlRoot("bierdopje")]
   [Serializable]
   public class SingleTvShowEpisodeResult : ITvShowEpisode
   {
      [XmlElement("response")]
      public TvShowEpisode tvShowEpisode;

      [XmlIgnore]
      public TvShowEpisode Episode
      {
         get { return tvShowEpisode; }
      }
   }
}