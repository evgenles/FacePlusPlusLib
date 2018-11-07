﻿using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using FacePlusPlusLib.Faces;
using FacePlusPlusLib.Faces.FaceSet;
using FacePlusPlusLib.Helpers;
using Newtonsoft.Json;

namespace FacePlusPlusLib
{
    public class FacePlusPlusClient
    {
        private readonly string _apiKey;
        private readonly string _apiSecret;
        private readonly HttpClient _httpClient;
        private readonly string _baseUrl = "https://api-us.faceplusplus.com";
        
        private const string Version = "v3";

        /// <summary>
        /// Initialize the face++ client
        /// </summary>
        /// <param name="apiKey">Api key received on faceplusplus.com</param>
        /// <param name="apiSecret">Api secret received on faceplusplus.com<</param>
        /// <param name="httpHandler">Custom http handler</param>
        /// <param name="customBaseUrl">Custom base url (default: https://api-us.faceplusplus.com)</param>
        public FacePlusPlusClient(string apiKey, string apiSecret, HttpClientHandler httpHandler = null,
            string customBaseUrl = null)
        {
            _apiKey = apiKey;
            _apiSecret = apiSecret;
            _httpClient = new HttpClient(httpHandler);
            if (customBaseUrl != null) _baseUrl = customBaseUrl;
        }

        /// <summary>
        /// Detect and analyze human faces within the image that you provided.
        /// Detect API can detect all the faces within the image. Each detected face gets its face_token, which can be used in follow-up analysis and operations. With a Standard API Key, you can specify a rectangle area within the image to perform face detection.
        /// Detect API can analyze detected faces directly, providing face landmarks and attributes information. With a Free API Key, only the 5 largest faces by its bounding box size can be analyzed, while you can use Face Analyze API to analyze the rest faces. With a Standard API Key, you can analyze all the detected faces.
        /// </summary>
        /// <param name="request">Request for detecting</param>
        /// <exception cref="HttpRequestException"></exception>
        /// <returns>Detect result</returns>
        public async Task<FaceDetectResponse> FaceDetectAsync(FaceDetectRequest request)
        {
            var detectUrl = $"{_baseUrl}/facepp/{Version}/detect";
            return await FaceApiRequest<FaceDetectRequest, FaceDetectResponse>(request, detectUrl);
        }

        /// <summary>
        /// Compare two faces and decide whether they are from the same person. You can upload image file or use face_token for face comparing. For image upload, the biggest face by the size of bounding box within the image will be used. For face_token, you shall get it by using Detect API.
        /// </summary>
        /// <param name="request">Request for comparing</param>
        /// <returns>Response of comparing</returns>
        /// <exception cref="HttpRequestException"></exception>
        public async Task<FaceCompareResponse> FaceCompareAsync(FaceCompareRequest request)
        {
            var compareUrl = $"{_baseUrl}/facepp/{Version}/compare";
            return await FaceApiRequest<FaceCompareRequest, FaceCompareResponse>(request, compareUrl);
        }

        /// <summary>
        /// Create a face collection called FaceSet to store face_token. One FaceSet can hold up to 10,000 face_token.
        /// </summary>
        /// <param name="request">Request for create faceSet</param>
        /// <returns>Response of face set creating</returns>
        public async Task<FaceSetAddOrCreateFaceResponse> FaceSetCreateAsync(FaceSetCreateRequest request)
        {
            var faceSetCreateUrl = $"{_baseUrl}/facepp/{Version}/faceset/create";
            return await FaceApiRequest<FaceSetCreateRequest, FaceSetAddOrCreateFaceResponse>(request, faceSetCreateUrl);
        }

        /// <summary>
        /// Add face_token into an existing FaceSet. One FaceSet can hold up to 10000 face_token.
        /// </summary>
        /// <param name="request">Request for add face to faceSet</param>
        /// <returns>Response of adding face to faceSet</returns>
        public async Task<FaceSetAddOrCreateFaceResponse> FaceSetAddFaceAsync(FaceSetAddOrRemoveFaceRequest request)
        {
            var faceSetAddFaceUrl = $"{_baseUrl}/facepp/{Version}/faceset/addface";
            return await FaceApiRequest<FaceSetAddOrRemoveFaceRequest, FaceSetAddOrCreateFaceResponse>(request, faceSetAddFaceUrl);
        }

        /// <summary>
        /// Remove all or part of face_token within a FaceSet.
        /// </summary>
        /// <param name="request">Request for remove face from face se</param>
        /// <returns>Response of removing face from face set</returns>
        public async Task<FaceSetRemoveFaceResponse> FaceSetRemoveFaceAsync(FaceSetAddOrRemoveFaceRequest request)
        {
            var faceSetRemoveFaceUrl = $"{_baseUrl}/facepp/{Version}/faceset/removeface";
            return await FaceApiRequest<FaceSetAddOrRemoveFaceRequest, FaceSetRemoveFaceResponse>(request, faceSetRemoveFaceUrl);
        }

        /// <summary>
        /// Delete a FaceSet.
        /// </summary>
        /// <param name="request">Request for delete</param>
        /// <returns>Response from deleting</returns>
        public async Task<FaceSetDeleteResponse> FaceSetDeleteAsync(FaceSetDeleteRequest request)
        {
            var faceSetDeleteUrl = $"{_baseUrl}/facepp/{Version}/faceset/delete";
            return await FaceApiRequest<FaceSetDeleteRequest, FaceSetDeleteResponse>(request, faceSetDeleteUrl);
        }
        

        private async Task<TResponse> FaceApiRequest<TRequest, TResponse>(TRequest request, string url)
            where TRequest : IRequest
            where TResponse : IResponse
        {
            var dictionaries = request.ConvertToDictionaries();
            var content =
                MultipartContentHelper.CreateMultipart(AddBaseConfiguration(dictionaries.Item1), dictionaries.Item2);

            var response = await _httpClient.PostAsync(url, content);
            if (response.IsSuccessStatusCode)
            {
                var json = await response.Content.ReadAsStringAsync();
                return JsonConvert.DeserializeObject<TResponse>(json);
            }
            else
            {
                if (response.Content == null)
                    throw new HttpRequestException(
                        $"Request not successful completed. Response code: {response.StatusCode}");

                var json = await response.Content.ReadAsStringAsync();
                throw new HttpRequestException(
                    $"Request not successful completed. Error: {JsonConvert.DeserializeObject<ErrorMessage>(json).Message}");
            }
        }

        private Dictionary<string, string> AddBaseConfiguration(Dictionary<string, string> paramDir)
        {
            paramDir.Add("api_key", _apiKey);
            paramDir.Add("api_secret", _apiSecret);
            return paramDir;
        }
    }
}