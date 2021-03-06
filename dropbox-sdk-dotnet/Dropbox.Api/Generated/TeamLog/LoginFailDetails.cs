// <auto-generated>
// Auto-generated by StoneAPI, do not modify.
// </auto-generated>

namespace Dropbox.Api.TeamLog
{
    using sys = System;
    using col = System.Collections.Generic;
    using re = System.Text.RegularExpressions;

    using enc = Dropbox.Api.Stone;

    /// <summary>
    /// <para>Failed to sign in.</para>
    /// </summary>
    public class LoginFailDetails
    {
        #pragma warning disable 108

        /// <summary>
        /// <para>The encoder instance.</para>
        /// </summary>
        internal static enc.StructEncoder<LoginFailDetails> Encoder = new LoginFailDetailsEncoder();

        /// <summary>
        /// <para>The decoder instance.</para>
        /// </summary>
        internal static enc.StructDecoder<LoginFailDetails> Decoder = new LoginFailDetailsDecoder();

        /// <summary>
        /// <para>Initializes a new instance of the <see cref="LoginFailDetails" />
        /// class.</para>
        /// </summary>
        /// <param name="loginMethod">Login method.</param>
        /// <param name="errorDetails">Error details.</param>
        /// <param name="isEmmManaged">Tells if the login device is EMM managed. Might be
        /// missing due to historical data gap.</param>
        public LoginFailDetails(LoginMethod loginMethod,
                                FailureDetailsLogInfo errorDetails,
                                bool? isEmmManaged = null)
        {
            if (loginMethod == null)
            {
                throw new sys.ArgumentNullException("loginMethod");
            }

            if (errorDetails == null)
            {
                throw new sys.ArgumentNullException("errorDetails");
            }

            this.LoginMethod = loginMethod;
            this.ErrorDetails = errorDetails;
            this.IsEmmManaged = isEmmManaged;
        }

        /// <summary>
        /// <para>Initializes a new instance of the <see cref="LoginFailDetails" />
        /// class.</para>
        /// </summary>
        /// <remarks>This is to construct an instance of the object when
        /// deserializing.</remarks>
        [sys.ComponentModel.EditorBrowsable(sys.ComponentModel.EditorBrowsableState.Never)]
        public LoginFailDetails()
        {
        }

        /// <summary>
        /// <para>Login method.</para>
        /// </summary>
        public LoginMethod LoginMethod { get; protected set; }

        /// <summary>
        /// <para>Error details.</para>
        /// </summary>
        public FailureDetailsLogInfo ErrorDetails { get; protected set; }

        /// <summary>
        /// <para>Tells if the login device is EMM managed. Might be missing due to historical
        /// data gap.</para>
        /// </summary>
        public bool? IsEmmManaged { get; protected set; }

        #region Encoder class

        /// <summary>
        /// <para>Encoder for  <see cref="LoginFailDetails" />.</para>
        /// </summary>
        private class LoginFailDetailsEncoder : enc.StructEncoder<LoginFailDetails>
        {
            /// <summary>
            /// <para>Encode fields of given value.</para>
            /// </summary>
            /// <param name="value">The value.</param>
            /// <param name="writer">The writer.</param>
            public override void EncodeFields(LoginFailDetails value, enc.IJsonWriter writer)
            {
                WriteProperty("login_method", value.LoginMethod, writer, global::Dropbox.Api.TeamLog.LoginMethod.Encoder);
                WriteProperty("error_details", value.ErrorDetails, writer, global::Dropbox.Api.TeamLog.FailureDetailsLogInfo.Encoder);
                if (value.IsEmmManaged != null)
                {
                    WriteProperty("is_emm_managed", value.IsEmmManaged.Value, writer, enc.BooleanEncoder.Instance);
                }
            }
        }

        #endregion


        #region Decoder class

        /// <summary>
        /// <para>Decoder for  <see cref="LoginFailDetails" />.</para>
        /// </summary>
        private class LoginFailDetailsDecoder : enc.StructDecoder<LoginFailDetails>
        {
            /// <summary>
            /// <para>Create a new instance of type <see cref="LoginFailDetails" />.</para>
            /// </summary>
            /// <returns>The struct instance.</returns>
            protected override LoginFailDetails Create()
            {
                return new LoginFailDetails();
            }

            /// <summary>
            /// <para>Set given field.</para>
            /// </summary>
            /// <param name="value">The field value.</param>
            /// <param name="fieldName">The field name.</param>
            /// <param name="reader">The json reader.</param>
            protected override void SetField(LoginFailDetails value, string fieldName, enc.IJsonReader reader)
            {
                switch (fieldName)
                {
                    case "login_method":
                        value.LoginMethod = global::Dropbox.Api.TeamLog.LoginMethod.Decoder.Decode(reader);
                        break;
                    case "error_details":
                        value.ErrorDetails = global::Dropbox.Api.TeamLog.FailureDetailsLogInfo.Decoder.Decode(reader);
                        break;
                    case "is_emm_managed":
                        value.IsEmmManaged = enc.BooleanDecoder.Instance.Decode(reader);
                        break;
                    default:
                        reader.Skip();
                        break;
                }
            }
        }

        #endregion
    }
}
