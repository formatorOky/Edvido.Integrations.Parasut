
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using RestSharp;
using Edvido.Integrations.Parasut.Client;
using Edvido.Integrations.Parasut.Model;

namespace Edvido.Integrations.Parasut.Api
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface ISalariesApi : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Archive
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Edvido.Integrations.Parasut.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="companyId">Firma ID</param>
        /// <param name="id">Maaş ID</param>
        /// <param name="include">Response ile birlikte geri dönmesini istediğiniz ilişkiler - *Available: employee, category, tags* (optional)</param>
        /// <returns>InlineResponse20110</returns>
        InlineResponse20110 ArchiveSalary (int? companyId, int? id, string include = null);

        /// <summary>
        /// Archive
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Edvido.Integrations.Parasut.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="companyId">Firma ID</param>
        /// <param name="id">Maaş ID</param>
        /// <param name="include">Response ile birlikte geri dönmesini istediğiniz ilişkiler - *Available: employee, category, tags* (optional)</param>
        /// <returns>ApiResponse of InlineResponse20110</returns>
        ApiResponse<InlineResponse20110> ArchiveSalaryWithHttpInfo (int? companyId, int? id, string include = null);
        /// <summary>
        /// Create
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Edvido.Integrations.Parasut.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="salaryForm"></param>
        /// <param name="companyId">Firma ID</param>
        /// <param name="include">Response ile birlikte geri dönmesini istediğiniz ilişkiler - *Available: employee, category, tags* (optional)</param>
        /// <returns>InlineResponse20110</returns>
        InlineResponse20110 CreateSalary (SalaryForm salaryForm, int? companyId, string include = null);

        /// <summary>
        /// Create
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Edvido.Integrations.Parasut.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="salaryForm"></param>
        /// <param name="companyId">Firma ID</param>
        /// <param name="include">Response ile birlikte geri dönmesini istediğiniz ilişkiler - *Available: employee, category, tags* (optional)</param>
        /// <returns>ApiResponse of InlineResponse20110</returns>
        ApiResponse<InlineResponse20110> CreateSalaryWithHttpInfo (SalaryForm salaryForm, int? companyId, string include = null);
        /// <summary>
        /// Delete
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Edvido.Integrations.Parasut.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="companyId">Firma ID</param>
        /// <param name="id">Maaş ID</param>
        /// <returns>Object</returns>
        Object DeleteSalary (int? companyId, int? id);

        /// <summary>
        /// Delete
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Edvido.Integrations.Parasut.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="companyId">Firma ID</param>
        /// <param name="id">Maaş ID</param>
        /// <returns>ApiResponse of Object</returns>
        ApiResponse<Object> DeleteSalaryWithHttpInfo (int? companyId, int? id);
        /// <summary>
        /// Pay
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Edvido.Integrations.Parasut.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="paymentForm"></param>
        /// <param name="companyId">Firma ID</param>
        /// <param name="id">Maaş ID</param>
        /// <param name="include">Response ile birlikte geri dönmesini istediğiniz ilişkiler - *Available: payable, tx* (optional)</param>
        /// <returns>InlineResponse2012</returns>
        InlineResponse2012 PaySalary (PaymentForm2 paymentForm, int? companyId, int? id, string include = null);

        /// <summary>
        /// Pay
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Edvido.Integrations.Parasut.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="paymentForm"></param>
        /// <param name="companyId">Firma ID</param>
        /// <param name="id">Maaş ID</param>
        /// <param name="include">Response ile birlikte geri dönmesini istediğiniz ilişkiler - *Available: payable, tx* (optional)</param>
        /// <returns>ApiResponse of InlineResponse2012</returns>
        ApiResponse<InlineResponse2012> PaySalaryWithHttpInfo (PaymentForm2 paymentForm, int? companyId, int? id, string include = null);
        /// <summary>
        /// Show
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Edvido.Integrations.Parasut.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="companyId">Firma ID</param>
        /// <param name="id">Maaş ID</param>
        /// <param name="include">Response ile birlikte geri dönmesini istediğiniz ilişkiler - *Available: employee, category, tags* (optional)</param>
        /// <returns>InlineResponse20110</returns>
        InlineResponse20110 ShowSalary (int? companyId, int? id, string include = null);

        /// <summary>
        /// Show
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Edvido.Integrations.Parasut.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="companyId">Firma ID</param>
        /// <param name="id">Maaş ID</param>
        /// <param name="include">Response ile birlikte geri dönmesini istediğiniz ilişkiler - *Available: employee, category, tags* (optional)</param>
        /// <returns>ApiResponse of InlineResponse20110</returns>
        ApiResponse<InlineResponse20110> ShowSalaryWithHttpInfo (int? companyId, int? id, string include = null);
        /// <summary>
        /// Unarchive
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Edvido.Integrations.Parasut.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="companyId">Firma ID</param>
        /// <param name="id">Maaş ID</param>
        /// <param name="include">Response ile birlikte geri dönmesini istediğiniz ilişkiler - *Available: employee, category, tags* (optional)</param>
        /// <returns>InlineResponse20110</returns>
        InlineResponse20110 UnarchiveSalary (int? companyId, int? id, string include = null);

        /// <summary>
        /// Unarchive
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Edvido.Integrations.Parasut.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="companyId">Firma ID</param>
        /// <param name="id">Maaş ID</param>
        /// <param name="include">Response ile birlikte geri dönmesini istediğiniz ilişkiler - *Available: employee, category, tags* (optional)</param>
        /// <returns>ApiResponse of InlineResponse20110</returns>
        ApiResponse<InlineResponse20110> UnarchiveSalaryWithHttpInfo (int? companyId, int? id, string include = null);
        /// <summary>
        /// Edit
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Edvido.Integrations.Parasut.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="salaryForm"></param>
        /// <param name="companyId">Firma ID</param>
        /// <param name="id">Maaş ID</param>
        /// <param name="include">Response ile birlikte geri dönmesini istediğiniz ilişkiler - *Available: employee, category, tags* (optional)</param>
        /// <returns>InlineResponse20110</returns>
        InlineResponse20110 UpdateSalary (SalaryForm1 salaryForm, int? companyId, int? id, string include = null);

        /// <summary>
        /// Edit
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Edvido.Integrations.Parasut.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="salaryForm"></param>
        /// <param name="companyId">Firma ID</param>
        /// <param name="id">Maaş ID</param>
        /// <param name="include">Response ile birlikte geri dönmesini istediğiniz ilişkiler - *Available: employee, category, tags* (optional)</param>
        /// <returns>ApiResponse of InlineResponse20110</returns>
        ApiResponse<InlineResponse20110> UpdateSalaryWithHttpInfo (SalaryForm1 salaryForm, int? companyId, int? id, string include = null);
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// Archive
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Edvido.Integrations.Parasut.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="companyId">Firma ID</param>
        /// <param name="id">Maaş ID</param>
        /// <param name="include">Response ile birlikte geri dönmesini istediğiniz ilişkiler - *Available: employee, category, tags* (optional)</param>
        /// <returns>Task of InlineResponse20110</returns>
        System.Threading.Tasks.Task<InlineResponse20110> ArchiveSalaryAsync (int? companyId, int? id, string include = null);

        /// <summary>
        /// Archive
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Edvido.Integrations.Parasut.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="companyId">Firma ID</param>
        /// <param name="id">Maaş ID</param>
        /// <param name="include">Response ile birlikte geri dönmesini istediğiniz ilişkiler - *Available: employee, category, tags* (optional)</param>
        /// <returns>Task of ApiResponse (InlineResponse20110)</returns>
        System.Threading.Tasks.Task<ApiResponse<InlineResponse20110>> ArchiveSalaryAsyncWithHttpInfo (int? companyId, int? id, string include = null);
        /// <summary>
        /// Create
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Edvido.Integrations.Parasut.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="salaryForm"></param>
        /// <param name="companyId">Firma ID</param>
        /// <param name="include">Response ile birlikte geri dönmesini istediğiniz ilişkiler - *Available: employee, category, tags* (optional)</param>
        /// <returns>Task of InlineResponse20110</returns>
        System.Threading.Tasks.Task<InlineResponse20110> CreateSalaryAsync (SalaryForm salaryForm, int? companyId, string include = null);

        /// <summary>
        /// Create
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Edvido.Integrations.Parasut.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="salaryForm"></param>
        /// <param name="companyId">Firma ID</param>
        /// <param name="include">Response ile birlikte geri dönmesini istediğiniz ilişkiler - *Available: employee, category, tags* (optional)</param>
        /// <returns>Task of ApiResponse (InlineResponse20110)</returns>
        System.Threading.Tasks.Task<ApiResponse<InlineResponse20110>> CreateSalaryAsyncWithHttpInfo (SalaryForm salaryForm, int? companyId, string include = null);
        /// <summary>
        /// Delete
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Edvido.Integrations.Parasut.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="companyId">Firma ID</param>
        /// <param name="id">Maaş ID</param>
        /// <returns>Task of Object</returns>
        System.Threading.Tasks.Task<Object> DeleteSalaryAsync (int? companyId, int? id);

        /// <summary>
        /// Delete
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Edvido.Integrations.Parasut.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="companyId">Firma ID</param>
        /// <param name="id">Maaş ID</param>
        /// <returns>Task of ApiResponse (Object)</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> DeleteSalaryAsyncWithHttpInfo (int? companyId, int? id);
        /// <summary>
        /// Pay
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Edvido.Integrations.Parasut.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="paymentForm"></param>
        /// <param name="companyId">Firma ID</param>
        /// <param name="id">Maaş ID</param>
        /// <param name="include">Response ile birlikte geri dönmesini istediğiniz ilişkiler - *Available: payable, tx* (optional)</param>
        /// <returns>Task of InlineResponse2012</returns>
        System.Threading.Tasks.Task<InlineResponse2012> PaySalaryAsync (PaymentForm2 paymentForm, int? companyId, int? id, string include = null);

        /// <summary>
        /// Pay
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Edvido.Integrations.Parasut.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="paymentForm"></param>
        /// <param name="companyId">Firma ID</param>
        /// <param name="id">Maaş ID</param>
        /// <param name="include">Response ile birlikte geri dönmesini istediğiniz ilişkiler - *Available: payable, tx* (optional)</param>
        /// <returns>Task of ApiResponse (InlineResponse2012)</returns>
        System.Threading.Tasks.Task<ApiResponse<InlineResponse2012>> PaySalaryAsyncWithHttpInfo (PaymentForm2 paymentForm, int? companyId, int? id, string include = null);
        /// <summary>
        /// Show
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Edvido.Integrations.Parasut.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="companyId">Firma ID</param>
        /// <param name="id">Maaş ID</param>
        /// <param name="include">Response ile birlikte geri dönmesini istediğiniz ilişkiler - *Available: employee, category, tags* (optional)</param>
        /// <returns>Task of InlineResponse20110</returns>
        System.Threading.Tasks.Task<InlineResponse20110> ShowSalaryAsync (int? companyId, int? id, string include = null);

        /// <summary>
        /// Show
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Edvido.Integrations.Parasut.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="companyId">Firma ID</param>
        /// <param name="id">Maaş ID</param>
        /// <param name="include">Response ile birlikte geri dönmesini istediğiniz ilişkiler - *Available: employee, category, tags* (optional)</param>
        /// <returns>Task of ApiResponse (InlineResponse20110)</returns>
        System.Threading.Tasks.Task<ApiResponse<InlineResponse20110>> ShowSalaryAsyncWithHttpInfo (int? companyId, int? id, string include = null);
        /// <summary>
        /// Unarchive
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Edvido.Integrations.Parasut.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="companyId">Firma ID</param>
        /// <param name="id">Maaş ID</param>
        /// <param name="include">Response ile birlikte geri dönmesini istediğiniz ilişkiler - *Available: employee, category, tags* (optional)</param>
        /// <returns>Task of InlineResponse20110</returns>
        System.Threading.Tasks.Task<InlineResponse20110> UnarchiveSalaryAsync (int? companyId, int? id, string include = null);

        /// <summary>
        /// Unarchive
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Edvido.Integrations.Parasut.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="companyId">Firma ID</param>
        /// <param name="id">Maaş ID</param>
        /// <param name="include">Response ile birlikte geri dönmesini istediğiniz ilişkiler - *Available: employee, category, tags* (optional)</param>
        /// <returns>Task of ApiResponse (InlineResponse20110)</returns>
        System.Threading.Tasks.Task<ApiResponse<InlineResponse20110>> UnarchiveSalaryAsyncWithHttpInfo (int? companyId, int? id, string include = null);
        /// <summary>
        /// Edit
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Edvido.Integrations.Parasut.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="salaryForm"></param>
        /// <param name="companyId">Firma ID</param>
        /// <param name="id">Maaş ID</param>
        /// <param name="include">Response ile birlikte geri dönmesini istediğiniz ilişkiler - *Available: employee, category, tags* (optional)</param>
        /// <returns>Task of InlineResponse20110</returns>
        System.Threading.Tasks.Task<InlineResponse20110> UpdateSalaryAsync (SalaryForm1 salaryForm, int? companyId, int? id, string include = null);

        /// <summary>
        /// Edit
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Edvido.Integrations.Parasut.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="salaryForm"></param>
        /// <param name="companyId">Firma ID</param>
        /// <param name="id">Maaş ID</param>
        /// <param name="include">Response ile birlikte geri dönmesini istediğiniz ilişkiler - *Available: employee, category, tags* (optional)</param>
        /// <returns>Task of ApiResponse (InlineResponse20110)</returns>
        System.Threading.Tasks.Task<ApiResponse<InlineResponse20110>> UpdateSalaryAsyncWithHttpInfo (SalaryForm1 salaryForm, int? companyId, int? id, string include = null);
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class SalariesApi : ISalariesApi
    {
        private Edvido.Integrations.Parasut.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

       

        /// <summary>
        /// Initializes a new instance of the <see cref="SalariesApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public SalariesApi(Configuration configuration = null)
        {
          
                this.Configuration = configuration;

            ExceptionFactory = Edvido.Integrations.Parasut.Client.Configuration.DefaultExceptionFactory;

            // ensure API client has configuration ready
            if (Configuration.ApiClient.Configuration == null)
            {
                this.Configuration.ApiClient.Configuration = this.Configuration;
            }
        }

     

        /// <summary>
        /// Sets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        [Obsolete("SetBasePath is deprecated, please do 'Configuration.ApiClient = new ApiClient(\"http://new-path\")' instead.")]
        public void SetBasePath(String basePath)
        {
            // do nothing
        }

        /// <summary>
        /// Gets or sets the configuration object
        /// </summary>
        /// <value>An instance of the Configuration</value>
        public Configuration Configuration {get; set;}

        /// <summary>
        /// Provides a factory method hook for the creation of exceptions.
        /// </summary>
        public Edvido.Integrations.Parasut.Client.ExceptionFactory ExceptionFactory
        {
            get
            {
                if (_exceptionFactory != null && _exceptionFactory.GetInvocationList().Length > 1)
                {
                    throw new InvalidOperationException("Multicast delegate for ExceptionFactory is unsupported.");
                }
                return _exceptionFactory;
            }
            set { _exceptionFactory = value; }
        }

        /// <summary>
        /// Gets the default header.
        /// </summary>
        /// <returns>Dictionary of HTTP header</returns>
        [Obsolete("DefaultHeader is deprecated, please use Configuration.DefaultHeader instead.")]
        public Dictionary<String, String> DefaultHeader()
        {
            return this.Configuration.DefaultHeader;
        }

        /// <summary>
        /// Add default header.
        /// </summary>
        /// <param name="key">Header field name.</param>
        /// <param name="value">Header field value.</param>
        /// <returns></returns>
        [Obsolete("AddDefaultHeader is deprecated, please use Configuration.AddDefaultHeader instead.")]
        public void AddDefaultHeader(string key, string value)
        {
            this.Configuration.AddDefaultHeader(key, value);
        }

        /// <summary>
        /// Archive 
        /// </summary>
        /// <exception cref="Edvido.Integrations.Parasut.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="companyId">Firma ID</param>
        /// <param name="id">Maaş ID</param>
        /// <param name="include">Response ile birlikte geri dönmesini istediğiniz ilişkiler - *Available: employee, category, tags* (optional)</param>
        /// <returns>InlineResponse20110</returns>
        public InlineResponse20110 ArchiveSalary (int? companyId, int? id, string include = null)
        {
             ApiResponse<InlineResponse20110> localVarResponse = ArchiveSalaryWithHttpInfo(companyId, id, include);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Archive 
        /// </summary>
        /// <exception cref="Edvido.Integrations.Parasut.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="companyId">Firma ID</param>
        /// <param name="id">Maaş ID</param>
        /// <param name="include">Response ile birlikte geri dönmesini istediğiniz ilişkiler - *Available: employee, category, tags* (optional)</param>
        /// <returns>ApiResponse of InlineResponse20110</returns>
        public ApiResponse< InlineResponse20110 > ArchiveSalaryWithHttpInfo (int? companyId, int? id, string include = null)
        {
            // verify the required parameter 'companyId' is set
            if (companyId == null)
                throw new ApiException(400, "Missing required parameter 'companyId' when calling SalariesApi->ArchiveSalary");
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling SalariesApi->ArchiveSalary");

            var localVarPath = "/{company_id}/salaries/{id}/archive";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/vnd.api+json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/vnd.api+json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (companyId != null) localVarPathParams.Add("company_id", Configuration.ApiClient.ParameterToString(companyId)); // path parameter
            if (id != null) localVarPathParams.Add("id", Configuration.ApiClient.ParameterToString(id)); // path parameter
            if (include != null) localVarQueryParams.Add("include", Configuration.ApiClient.ParameterToString(include)); // query parameter

          

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.PATCH, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("ArchiveSalary", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<InlineResponse20110>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (InlineResponse20110) Configuration.ApiClient.Deserialize(localVarResponse, typeof(InlineResponse20110)));
            
        }

        /// <summary>
        /// Archive 
        /// </summary>
        /// <exception cref="Edvido.Integrations.Parasut.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="companyId">Firma ID</param>
        /// <param name="id">Maaş ID</param>
        /// <param name="include">Response ile birlikte geri dönmesini istediğiniz ilişkiler - *Available: employee, category, tags* (optional)</param>
        /// <returns>Task of InlineResponse20110</returns>
        public async System.Threading.Tasks.Task<InlineResponse20110> ArchiveSalaryAsync (int? companyId, int? id, string include = null)
        {
             ApiResponse<InlineResponse20110> localVarResponse = await ArchiveSalaryAsyncWithHttpInfo(companyId, id, include);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Archive 
        /// </summary>
        /// <exception cref="Edvido.Integrations.Parasut.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="companyId">Firma ID</param>
        /// <param name="id">Maaş ID</param>
        /// <param name="include">Response ile birlikte geri dönmesini istediğiniz ilişkiler - *Available: employee, category, tags* (optional)</param>
        /// <returns>Task of ApiResponse (InlineResponse20110)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<InlineResponse20110>> ArchiveSalaryAsyncWithHttpInfo (int? companyId, int? id, string include = null)
        {
            // verify the required parameter 'companyId' is set
            if (companyId == null)
                throw new ApiException(400, "Missing required parameter 'companyId' when calling SalariesApi->ArchiveSalary");
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling SalariesApi->ArchiveSalary");

            var localVarPath = "/{company_id}/salaries/{id}/archive";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/vnd.api+json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/vnd.api+json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (companyId != null) localVarPathParams.Add("company_id", Configuration.ApiClient.ParameterToString(companyId)); // path parameter
            if (id != null) localVarPathParams.Add("id", Configuration.ApiClient.ParameterToString(id)); // path parameter
            if (include != null) localVarQueryParams.Add("include", Configuration.ApiClient.ParameterToString(include)); // query parameter

         

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.PATCH, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("ArchiveSalary", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<InlineResponse20110>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (InlineResponse20110) Configuration.ApiClient.Deserialize(localVarResponse, typeof(InlineResponse20110)));
            
        }

        /// <summary>
        /// Create 
        /// </summary>
        /// <exception cref="Edvido.Integrations.Parasut.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="salaryForm"></param>
        /// <param name="companyId">Firma ID</param>
        /// <param name="include">Response ile birlikte geri dönmesini istediğiniz ilişkiler - *Available: employee, category, tags* (optional)</param>
        /// <returns>InlineResponse20110</returns>
        public InlineResponse20110 CreateSalary (SalaryForm salaryForm, int? companyId, string include = null)
        {
             ApiResponse<InlineResponse20110> localVarResponse = CreateSalaryWithHttpInfo(salaryForm, companyId, include);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Create 
        /// </summary>
        /// <exception cref="Edvido.Integrations.Parasut.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="salaryForm"></param>
        /// <param name="companyId">Firma ID</param>
        /// <param name="include">Response ile birlikte geri dönmesini istediğiniz ilişkiler - *Available: employee, category, tags* (optional)</param>
        /// <returns>ApiResponse of InlineResponse20110</returns>
        public ApiResponse< InlineResponse20110 > CreateSalaryWithHttpInfo (SalaryForm salaryForm, int? companyId, string include = null)
        {
            // verify the required parameter 'salaryForm' is set
            if (salaryForm == null)
                throw new ApiException(400, "Missing required parameter 'salaryForm' when calling SalariesApi->CreateSalary");
            // verify the required parameter 'companyId' is set
            if (companyId == null)
                throw new ApiException(400, "Missing required parameter 'companyId' when calling SalariesApi->CreateSalary");

            var localVarPath = "/{company_id}/salaries";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/vnd.api+json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/vnd.api+json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (companyId != null) localVarPathParams.Add("company_id", Configuration.ApiClient.ParameterToString(companyId)); // path parameter
            if (include != null) localVarQueryParams.Add("include", Configuration.ApiClient.ParameterToString(include)); // query parameter
            if (salaryForm != null && salaryForm.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(salaryForm); // http body (model) parameter
            }
            else
            {
                localVarPostBody = salaryForm; // byte array
            }

          

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("CreateSalary", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<InlineResponse20110>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (InlineResponse20110) Configuration.ApiClient.Deserialize(localVarResponse, typeof(InlineResponse20110)));
            
        }

        /// <summary>
        /// Create 
        /// </summary>
        /// <exception cref="Edvido.Integrations.Parasut.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="salaryForm"></param>
        /// <param name="companyId">Firma ID</param>
        /// <param name="include">Response ile birlikte geri dönmesini istediğiniz ilişkiler - *Available: employee, category, tags* (optional)</param>
        /// <returns>Task of InlineResponse20110</returns>
        public async System.Threading.Tasks.Task<InlineResponse20110> CreateSalaryAsync (SalaryForm salaryForm, int? companyId, string include = null)
        {
             ApiResponse<InlineResponse20110> localVarResponse = await CreateSalaryAsyncWithHttpInfo(salaryForm, companyId, include);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Create 
        /// </summary>
        /// <exception cref="Edvido.Integrations.Parasut.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="salaryForm"></param>
        /// <param name="companyId">Firma ID</param>
        /// <param name="include">Response ile birlikte geri dönmesini istediğiniz ilişkiler - *Available: employee, category, tags* (optional)</param>
        /// <returns>Task of ApiResponse (InlineResponse20110)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<InlineResponse20110>> CreateSalaryAsyncWithHttpInfo (SalaryForm salaryForm, int? companyId, string include = null)
        {
            // verify the required parameter 'salaryForm' is set
            if (salaryForm == null)
                throw new ApiException(400, "Missing required parameter 'salaryForm' when calling SalariesApi->CreateSalary");
            // verify the required parameter 'companyId' is set
            if (companyId == null)
                throw new ApiException(400, "Missing required parameter 'companyId' when calling SalariesApi->CreateSalary");

            var localVarPath = "/{company_id}/salaries";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/vnd.api+json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/vnd.api+json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (companyId != null) localVarPathParams.Add("company_id", Configuration.ApiClient.ParameterToString(companyId)); // path parameter
            if (include != null) localVarQueryParams.Add("include", Configuration.ApiClient.ParameterToString(include)); // query parameter
            if (salaryForm != null && salaryForm.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(salaryForm); // http body (model) parameter
            }
            else
            {
                localVarPostBody = salaryForm; // byte array
            }

           
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("CreateSalary", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<InlineResponse20110>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (InlineResponse20110) Configuration.ApiClient.Deserialize(localVarResponse, typeof(InlineResponse20110)));
            
        }

        /// <summary>
        /// Delete 
        /// </summary>
        /// <exception cref="Edvido.Integrations.Parasut.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="companyId">Firma ID</param>
        /// <param name="id">Maaş ID</param>
        /// <returns>Object</returns>
        public Object DeleteSalary (int? companyId, int? id)
        {
             ApiResponse<Object> localVarResponse = DeleteSalaryWithHttpInfo(companyId, id);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Delete 
        /// </summary>
        /// <exception cref="Edvido.Integrations.Parasut.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="companyId">Firma ID</param>
        /// <param name="id">Maaş ID</param>
        /// <returns>ApiResponse of Object</returns>
        public ApiResponse< Object > DeleteSalaryWithHttpInfo (int? companyId, int? id)
        {
            // verify the required parameter 'companyId' is set
            if (companyId == null)
                throw new ApiException(400, "Missing required parameter 'companyId' when calling SalariesApi->DeleteSalary");
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling SalariesApi->DeleteSalary");

            var localVarPath = "/{company_id}/salaries/{id}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/vnd.api+json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/vnd.api+json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (companyId != null) localVarPathParams.Add("company_id", Configuration.ApiClient.ParameterToString(companyId)); // path parameter
            if (id != null) localVarPathParams.Add("id", Configuration.ApiClient.ParameterToString(id)); // path parameter

           

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.DELETE, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("DeleteSalary", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Object) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Object)));
            
        }

        /// <summary>
        /// Delete 
        /// </summary>
        /// <exception cref="Edvido.Integrations.Parasut.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="companyId">Firma ID</param>
        /// <param name="id">Maaş ID</param>
        /// <returns>Task of Object</returns>
        public async System.Threading.Tasks.Task<Object> DeleteSalaryAsync (int? companyId, int? id)
        {
             ApiResponse<Object> localVarResponse = await DeleteSalaryAsyncWithHttpInfo(companyId, id);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Delete 
        /// </summary>
        /// <exception cref="Edvido.Integrations.Parasut.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="companyId">Firma ID</param>
        /// <param name="id">Maaş ID</param>
        /// <returns>Task of ApiResponse (Object)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> DeleteSalaryAsyncWithHttpInfo (int? companyId, int? id)
        {
            // verify the required parameter 'companyId' is set
            if (companyId == null)
                throw new ApiException(400, "Missing required parameter 'companyId' when calling SalariesApi->DeleteSalary");
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling SalariesApi->DeleteSalary");

            var localVarPath = "/{company_id}/salaries/{id}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/vnd.api+json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/vnd.api+json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (companyId != null) localVarPathParams.Add("company_id", Configuration.ApiClient.ParameterToString(companyId)); // path parameter
            if (id != null) localVarPathParams.Add("id", Configuration.ApiClient.ParameterToString(id)); // path parameter

         

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.DELETE, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("DeleteSalary", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Object) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Object)));
            
        }

        /// <summary>
        /// Pay 
        /// </summary>
        /// <exception cref="Edvido.Integrations.Parasut.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="paymentForm"></param>
        /// <param name="companyId">Firma ID</param>
        /// <param name="id">Maaş ID</param>
        /// <param name="include">Response ile birlikte geri dönmesini istediğiniz ilişkiler - *Available: payable, tx* (optional)</param>
        /// <returns>InlineResponse2012</returns>
        public InlineResponse2012 PaySalary (PaymentForm2 paymentForm, int? companyId, int? id, string include = null)
        {
             ApiResponse<InlineResponse2012> localVarResponse = PaySalaryWithHttpInfo(paymentForm, companyId, id, include);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Pay 
        /// </summary>
        /// <exception cref="Edvido.Integrations.Parasut.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="paymentForm"></param>
        /// <param name="companyId">Firma ID</param>
        /// <param name="id">Maaş ID</param>
        /// <param name="include">Response ile birlikte geri dönmesini istediğiniz ilişkiler - *Available: payable, tx* (optional)</param>
        /// <returns>ApiResponse of InlineResponse2012</returns>
        public ApiResponse< InlineResponse2012 > PaySalaryWithHttpInfo (PaymentForm2 paymentForm, int? companyId, int? id, string include = null)
        {
            // verify the required parameter 'paymentForm' is set
            if (paymentForm == null)
                throw new ApiException(400, "Missing required parameter 'paymentForm' when calling SalariesApi->PaySalary");
            // verify the required parameter 'companyId' is set
            if (companyId == null)
                throw new ApiException(400, "Missing required parameter 'companyId' when calling SalariesApi->PaySalary");
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling SalariesApi->PaySalary");

            var localVarPath = "/{company_id}/salaries/{id}/payments";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/vnd.api+json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/vnd.api+json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (companyId != null) localVarPathParams.Add("company_id", Configuration.ApiClient.ParameterToString(companyId)); // path parameter
            if (id != null) localVarPathParams.Add("id", Configuration.ApiClient.ParameterToString(id)); // path parameter
            if (include != null) localVarQueryParams.Add("include", Configuration.ApiClient.ParameterToString(include)); // query parameter
            if (paymentForm != null && paymentForm.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(paymentForm); // http body (model) parameter
            }
            else
            {
                localVarPostBody = paymentForm; // byte array
            }

         

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("PaySalary", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<InlineResponse2012>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (InlineResponse2012) Configuration.ApiClient.Deserialize(localVarResponse, typeof(InlineResponse2012)));
            
        }

        /// <summary>
        /// Pay 
        /// </summary>
        /// <exception cref="Edvido.Integrations.Parasut.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="paymentForm"></param>
        /// <param name="companyId">Firma ID</param>
        /// <param name="id">Maaş ID</param>
        /// <param name="include">Response ile birlikte geri dönmesini istediğiniz ilişkiler - *Available: payable, tx* (optional)</param>
        /// <returns>Task of InlineResponse2012</returns>
        public async System.Threading.Tasks.Task<InlineResponse2012> PaySalaryAsync (PaymentForm2 paymentForm, int? companyId, int? id, string include = null)
        {
             ApiResponse<InlineResponse2012> localVarResponse = await PaySalaryAsyncWithHttpInfo(paymentForm, companyId, id, include);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Pay 
        /// </summary>
        /// <exception cref="Edvido.Integrations.Parasut.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="paymentForm"></param>
        /// <param name="companyId">Firma ID</param>
        /// <param name="id">Maaş ID</param>
        /// <param name="include">Response ile birlikte geri dönmesini istediğiniz ilişkiler - *Available: payable, tx* (optional)</param>
        /// <returns>Task of ApiResponse (InlineResponse2012)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<InlineResponse2012>> PaySalaryAsyncWithHttpInfo (PaymentForm2 paymentForm, int? companyId, int? id, string include = null)
        {
            // verify the required parameter 'paymentForm' is set
            if (paymentForm == null)
                throw new ApiException(400, "Missing required parameter 'paymentForm' when calling SalariesApi->PaySalary");
            // verify the required parameter 'companyId' is set
            if (companyId == null)
                throw new ApiException(400, "Missing required parameter 'companyId' when calling SalariesApi->PaySalary");
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling SalariesApi->PaySalary");

            var localVarPath = "/{company_id}/salaries/{id}/payments";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/vnd.api+json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/vnd.api+json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (companyId != null) localVarPathParams.Add("company_id", Configuration.ApiClient.ParameterToString(companyId)); // path parameter
            if (id != null) localVarPathParams.Add("id", Configuration.ApiClient.ParameterToString(id)); // path parameter
            if (include != null) localVarQueryParams.Add("include", Configuration.ApiClient.ParameterToString(include)); // query parameter
            if (paymentForm != null && paymentForm.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(paymentForm); // http body (model) parameter
            }
            else
            {
                localVarPostBody = paymentForm; // byte array
            }

          

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("PaySalary", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<InlineResponse2012>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (InlineResponse2012) Configuration.ApiClient.Deserialize(localVarResponse, typeof(InlineResponse2012)));
            
        }

        /// <summary>
        /// Show 
        /// </summary>
        /// <exception cref="Edvido.Integrations.Parasut.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="companyId">Firma ID</param>
        /// <param name="id">Maaş ID</param>
        /// <param name="include">Response ile birlikte geri dönmesini istediğiniz ilişkiler - *Available: employee, category, tags* (optional)</param>
        /// <returns>InlineResponse20110</returns>
        public InlineResponse20110 ShowSalary (int? companyId, int? id, string include = null)
        {
             ApiResponse<InlineResponse20110> localVarResponse = ShowSalaryWithHttpInfo(companyId, id, include);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Show 
        /// </summary>
        /// <exception cref="Edvido.Integrations.Parasut.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="companyId">Firma ID</param>
        /// <param name="id">Maaş ID</param>
        /// <param name="include">Response ile birlikte geri dönmesini istediğiniz ilişkiler - *Available: employee, category, tags* (optional)</param>
        /// <returns>ApiResponse of InlineResponse20110</returns>
        public ApiResponse< InlineResponse20110 > ShowSalaryWithHttpInfo (int? companyId, int? id, string include = null)
        {
            // verify the required parameter 'companyId' is set
            if (companyId == null)
                throw new ApiException(400, "Missing required parameter 'companyId' when calling SalariesApi->ShowSalary");
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling SalariesApi->ShowSalary");

            var localVarPath = "/{company_id}/salaries/{id}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/vnd.api+json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/vnd.api+json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (companyId != null) localVarPathParams.Add("company_id", Configuration.ApiClient.ParameterToString(companyId)); // path parameter
            if (id != null) localVarPathParams.Add("id", Configuration.ApiClient.ParameterToString(id)); // path parameter
            if (include != null) localVarQueryParams.Add("include", Configuration.ApiClient.ParameterToString(include)); // query parameter

          

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("ShowSalary", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<InlineResponse20110>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (InlineResponse20110) Configuration.ApiClient.Deserialize(localVarResponse, typeof(InlineResponse20110)));
            
        }

        /// <summary>
        /// Show 
        /// </summary>
        /// <exception cref="Edvido.Integrations.Parasut.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="companyId">Firma ID</param>
        /// <param name="id">Maaş ID</param>
        /// <param name="include">Response ile birlikte geri dönmesini istediğiniz ilişkiler - *Available: employee, category, tags* (optional)</param>
        /// <returns>Task of InlineResponse20110</returns>
        public async System.Threading.Tasks.Task<InlineResponse20110> ShowSalaryAsync (int? companyId, int? id, string include = null)
        {
             ApiResponse<InlineResponse20110> localVarResponse = await ShowSalaryAsyncWithHttpInfo(companyId, id, include);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Show 
        /// </summary>
        /// <exception cref="Edvido.Integrations.Parasut.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="companyId">Firma ID</param>
        /// <param name="id">Maaş ID</param>
        /// <param name="include">Response ile birlikte geri dönmesini istediğiniz ilişkiler - *Available: employee, category, tags* (optional)</param>
        /// <returns>Task of ApiResponse (InlineResponse20110)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<InlineResponse20110>> ShowSalaryAsyncWithHttpInfo (int? companyId, int? id, string include = null)
        {
            // verify the required parameter 'companyId' is set
            if (companyId == null)
                throw new ApiException(400, "Missing required parameter 'companyId' when calling SalariesApi->ShowSalary");
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling SalariesApi->ShowSalary");

            var localVarPath = "/{company_id}/salaries/{id}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/vnd.api+json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/vnd.api+json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (companyId != null) localVarPathParams.Add("company_id", Configuration.ApiClient.ParameterToString(companyId)); // path parameter
            if (id != null) localVarPathParams.Add("id", Configuration.ApiClient.ParameterToString(id)); // path parameter
            if (include != null) localVarQueryParams.Add("include", Configuration.ApiClient.ParameterToString(include)); // query parameter

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("ShowSalary", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<InlineResponse20110>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (InlineResponse20110) Configuration.ApiClient.Deserialize(localVarResponse, typeof(InlineResponse20110)));
            
        }

        /// <summary>
        /// Unarchive 
        /// </summary>
        /// <exception cref="Edvido.Integrations.Parasut.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="companyId">Firma ID</param>
        /// <param name="id">Maaş ID</param>
        /// <param name="include">Response ile birlikte geri dönmesini istediğiniz ilişkiler - *Available: employee, category, tags* (optional)</param>
        /// <returns>InlineResponse20110</returns>
        public InlineResponse20110 UnarchiveSalary (int? companyId, int? id, string include = null)
        {
             ApiResponse<InlineResponse20110> localVarResponse = UnarchiveSalaryWithHttpInfo(companyId, id, include);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Unarchive 
        /// </summary>
        /// <exception cref="Edvido.Integrations.Parasut.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="companyId">Firma ID</param>
        /// <param name="id">Maaş ID</param>
        /// <param name="include">Response ile birlikte geri dönmesini istediğiniz ilişkiler - *Available: employee, category, tags* (optional)</param>
        /// <returns>ApiResponse of InlineResponse20110</returns>
        public ApiResponse< InlineResponse20110 > UnarchiveSalaryWithHttpInfo (int? companyId, int? id, string include = null)
        {
            // verify the required parameter 'companyId' is set
            if (companyId == null)
                throw new ApiException(400, "Missing required parameter 'companyId' when calling SalariesApi->UnarchiveSalary");
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling SalariesApi->UnarchiveSalary");

            var localVarPath = "/{company_id}/salaries/{id}/unarchive";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/vnd.api+json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/vnd.api+json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (companyId != null) localVarPathParams.Add("company_id", Configuration.ApiClient.ParameterToString(companyId)); // path parameter
            if (id != null) localVarPathParams.Add("id", Configuration.ApiClient.ParameterToString(id)); // path parameter
            if (include != null) localVarQueryParams.Add("include", Configuration.ApiClient.ParameterToString(include)); // query parameter

          

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.PATCH, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("UnarchiveSalary", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<InlineResponse20110>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (InlineResponse20110) Configuration.ApiClient.Deserialize(localVarResponse, typeof(InlineResponse20110)));
            
        }

        /// <summary>
        /// Unarchive 
        /// </summary>
        /// <exception cref="Edvido.Integrations.Parasut.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="companyId">Firma ID</param>
        /// <param name="id">Maaş ID</param>
        /// <param name="include">Response ile birlikte geri dönmesini istediğiniz ilişkiler - *Available: employee, category, tags* (optional)</param>
        /// <returns>Task of InlineResponse20110</returns>
        public async System.Threading.Tasks.Task<InlineResponse20110> UnarchiveSalaryAsync (int? companyId, int? id, string include = null)
        {
             ApiResponse<InlineResponse20110> localVarResponse = await UnarchiveSalaryAsyncWithHttpInfo(companyId, id, include);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Unarchive 
        /// </summary>
        /// <exception cref="Edvido.Integrations.Parasut.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="companyId">Firma ID</param>
        /// <param name="id">Maaş ID</param>
        /// <param name="include">Response ile birlikte geri dönmesini istediğiniz ilişkiler - *Available: employee, category, tags* (optional)</param>
        /// <returns>Task of ApiResponse (InlineResponse20110)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<InlineResponse20110>> UnarchiveSalaryAsyncWithHttpInfo (int? companyId, int? id, string include = null)
        {
            // verify the required parameter 'companyId' is set
            if (companyId == null)
                throw new ApiException(400, "Missing required parameter 'companyId' when calling SalariesApi->UnarchiveSalary");
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling SalariesApi->UnarchiveSalary");

            var localVarPath = "/{company_id}/salaries/{id}/unarchive";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/vnd.api+json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/vnd.api+json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (companyId != null) localVarPathParams.Add("company_id", Configuration.ApiClient.ParameterToString(companyId)); // path parameter
            if (id != null) localVarPathParams.Add("id", Configuration.ApiClient.ParameterToString(id)); // path parameter
            if (include != null) localVarQueryParams.Add("include", Configuration.ApiClient.ParameterToString(include)); // query parameter

           

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.PATCH, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("UnarchiveSalary", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<InlineResponse20110>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (InlineResponse20110) Configuration.ApiClient.Deserialize(localVarResponse, typeof(InlineResponse20110)));
            
        }

        /// <summary>
        /// Edit 
        /// </summary>
        /// <exception cref="Edvido.Integrations.Parasut.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="salaryForm"></param>
        /// <param name="companyId">Firma ID</param>
        /// <param name="id">Maaş ID</param>
        /// <param name="include">Response ile birlikte geri dönmesini istediğiniz ilişkiler - *Available: employee, category, tags* (optional)</param>
        /// <returns>InlineResponse20110</returns>
        public InlineResponse20110 UpdateSalary (SalaryForm1 salaryForm, int? companyId, int? id, string include = null)
        {
             ApiResponse<InlineResponse20110> localVarResponse = UpdateSalaryWithHttpInfo(salaryForm, companyId, id, include);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Edit 
        /// </summary>
        /// <exception cref="Edvido.Integrations.Parasut.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="salaryForm"></param>
        /// <param name="companyId">Firma ID</param>
        /// <param name="id">Maaş ID</param>
        /// <param name="include">Response ile birlikte geri dönmesini istediğiniz ilişkiler - *Available: employee, category, tags* (optional)</param>
        /// <returns>ApiResponse of InlineResponse20110</returns>
        public ApiResponse< InlineResponse20110 > UpdateSalaryWithHttpInfo (SalaryForm1 salaryForm, int? companyId, int? id, string include = null)
        {
            // verify the required parameter 'salaryForm' is set
            if (salaryForm == null)
                throw new ApiException(400, "Missing required parameter 'salaryForm' when calling SalariesApi->UpdateSalary");
            // verify the required parameter 'companyId' is set
            if (companyId == null)
                throw new ApiException(400, "Missing required parameter 'companyId' when calling SalariesApi->UpdateSalary");
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling SalariesApi->UpdateSalary");

            var localVarPath = "/{company_id}/salaries/{id}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/vnd.api+json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/vnd.api+json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (companyId != null) localVarPathParams.Add("company_id", Configuration.ApiClient.ParameterToString(companyId)); // path parameter
            if (id != null) localVarPathParams.Add("id", Configuration.ApiClient.ParameterToString(id)); // path parameter
            if (include != null) localVarQueryParams.Add("include", Configuration.ApiClient.ParameterToString(include)); // query parameter
            if (salaryForm != null && salaryForm.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(salaryForm); // http body (model) parameter
            }
            else
            {
                localVarPostBody = salaryForm; // byte array
            }

          

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("UpdateSalary", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<InlineResponse20110>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (InlineResponse20110) Configuration.ApiClient.Deserialize(localVarResponse, typeof(InlineResponse20110)));
            
        }

        /// <summary>
        /// Edit 
        /// </summary>
        /// <exception cref="Edvido.Integrations.Parasut.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="salaryForm"></param>
        /// <param name="companyId">Firma ID</param>
        /// <param name="id">Maaş ID</param>
        /// <param name="include">Response ile birlikte geri dönmesini istediğiniz ilişkiler - *Available: employee, category, tags* (optional)</param>
        /// <returns>Task of InlineResponse20110</returns>
        public async System.Threading.Tasks.Task<InlineResponse20110> UpdateSalaryAsync (SalaryForm1 salaryForm, int? companyId, int? id, string include = null)
        {
             ApiResponse<InlineResponse20110> localVarResponse = await UpdateSalaryAsyncWithHttpInfo(salaryForm, companyId, id, include);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Edit 
        /// </summary>
        /// <exception cref="Edvido.Integrations.Parasut.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="salaryForm"></param>
        /// <param name="companyId">Firma ID</param>
        /// <param name="id">Maaş ID</param>
        /// <param name="include">Response ile birlikte geri dönmesini istediğiniz ilişkiler - *Available: employee, category, tags* (optional)</param>
        /// <returns>Task of ApiResponse (InlineResponse20110)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<InlineResponse20110>> UpdateSalaryAsyncWithHttpInfo (SalaryForm1 salaryForm, int? companyId, int? id, string include = null)
        {
            // verify the required parameter 'salaryForm' is set
            if (salaryForm == null)
                throw new ApiException(400, "Missing required parameter 'salaryForm' when calling SalariesApi->UpdateSalary");
            // verify the required parameter 'companyId' is set
            if (companyId == null)
                throw new ApiException(400, "Missing required parameter 'companyId' when calling SalariesApi->UpdateSalary");
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling SalariesApi->UpdateSalary");

            var localVarPath = "/{company_id}/salaries/{id}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/vnd.api+json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/vnd.api+json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (companyId != null) localVarPathParams.Add("company_id", Configuration.ApiClient.ParameterToString(companyId)); // path parameter
            if (id != null) localVarPathParams.Add("id", Configuration.ApiClient.ParameterToString(id)); // path parameter
            if (include != null) localVarQueryParams.Add("include", Configuration.ApiClient.ParameterToString(include)); // query parameter
            if (salaryForm != null && salaryForm.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(salaryForm); // http body (model) parameter
            }
            else
            {
                localVarPostBody = salaryForm; // byte array
            }

          

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("UpdateSalary", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<InlineResponse20110>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (InlineResponse20110) Configuration.ApiClient.Deserialize(localVarResponse, typeof(InlineResponse20110)));
            
        }

    }
}
