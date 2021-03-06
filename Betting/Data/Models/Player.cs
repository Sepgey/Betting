﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Betting.Data.Models
{
    public class Player
    {
        public Player()
        {
            PlayerStatistics = new HashSet<PlayerStatistic>();
        }

        [Key]
        public int PlayerId { get; set; }

        public bool IsInjured { get; set; }

        [MaxLength(64)]
        public string Name { get; set; }

        [ForeignKey(nameof(Position))]
        public int PositionId { get; set; }

        public int SquadNumber { get; set; }

        [ForeignKey(nameof(Team))]
        public int TeamId { get; set; }

        public virtual Position Position { get; set; }
        public virtual Team Team { get; set; }
        public virtual ICollection<PlayerStatistic> PlayerStatistics { get; set; }
    }
}
