using System;
using System.Runtime.Serialization;

namespace Chalk.SubtitlesManagement
{
   [DataContract(Name = "TvShow", Namespace = "")]
   public class TvShow
   {
      [DataMember(Name = "showid")]
      public int id;

      [DataMember(Name = "tvdbid")]
      public int tvDbId;

      [DataMember(Name = "showname")]
      public string showName;

      [DataMember(Name = "showlink")]
      public string showLink;

      [DataMember(Name = "firstaired")]
      public DateTime firstAired;

      [DataMember(Name = "lastaired")]
      public DateTime lastAired;

      [DataMember(Name = "nextEpisode")]
      public DateTime nextEpisode;

      [DataMember(Name = "season")]
      public int season;

      [DataMember(Name = "episodes")]
      public int numberOfEpisodes;

      [DataMember(Name = "genres")]
      public Genres genres;

      [DataMember(Name = "showstatus")]
      public string showStatus;

      [DataMember(Name = "network")]
      public string network;

      [DataMember(Name = "airTime")]
      public DateTime airTime;

      [DataMember(Name = "runTime")]
      public TimeSpan runTime;

      [DataMember(Name = "score")]
      public Single score;

      [DataMember(Name = "favorites")]
      public int favorites;

      [DataMember(Name = "has_translators")]
      public bool hasTranslators;

      [DataMember(Name = "summary")]
      public string summary;

      [DataMember(Name = "status")] 
      public bool status;

      [DataMember(Name = "cached")]
      public bool cached;
   }
}