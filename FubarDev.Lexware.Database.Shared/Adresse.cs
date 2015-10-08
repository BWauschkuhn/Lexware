﻿//-----------------------------------------------------------------------
// <copyright file="Adresse.cs" company="Fubar Development Junker">
//     Copyright (c) Fubar Development Junker. All rights reserved.
// </copyright>
// <author>Mark Junker</author>
//-----------------------------------------------------------------------

namespace FubarDev.Lexware.Database.Shared
{
    /// <summary>
    /// Allgemeine Adressdaten
    /// </summary>
    public class Adresse
    {
        /// <summary>
        /// Holt oder setzt die Anrede
        /// </summary>
        public virtual string Anrede { get; set; }

        /// <summary>
        /// Holt oder setzt die Firma
        /// </summary>
        public virtual string Firma { get; set; }

        /// <summary>
        /// Holt oder setzt die Postleitzahl
        /// </summary>
        public virtual string Plz { get; set; }

        /// <summary>
        /// Holt oder setzt den Ort
        /// </summary>
        public virtual string Ort { get; set; }
    }
}
