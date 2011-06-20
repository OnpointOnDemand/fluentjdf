﻿using System.Collections.Generic;
using System.Xml.Linq;
using FluentJdf.Schema;

namespace FluentJdf.LinqToJdf {
    /// <summary>
    /// Base class for XDocument descendants in FluentJDF.
    /// </summary>
    public class FluentJdfDocumentBase : XDocument {
        /// <summary>
        /// Gets and sets the validator.
        /// </summary>
        protected Validator validator;

        /// <summary>
        /// Constructor.
        /// </summary>
        protected FluentJdfDocumentBase() {
            validator = new Validator(this);
        }

        /// <summary>
        /// Gets the validity of the ticket.  Null if Validate
        /// has never been called.
        /// </summary>
        public bool? IsValid{ get { return validator.IsValid; }}

        /// <summary>
        /// Gets the current collection of validation errors.
        /// </summary>
        public IList<ValidationMessage> Errors { get { return validator.Errors; }}

        /// <summary>
        /// Gets the current collection of validation warnings.
        /// </summary>
        public IList<ValidationMessage> Warnings {get { return validator.Warnings; }}
    }
}