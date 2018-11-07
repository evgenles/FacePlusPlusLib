using System.Net.Http;
using System.Threading.Tasks;
using FacePlusPlusLib.Faces;
using FacePlusPlusLib.Faces.Face;
using FacePlusPlusLib.Faces.FaceSet;

namespace FacePlusPlusLib
{
    /// <summary>
    /// Client for FacePlusPlus Api
    /// </summary>
    public interface IFacePlusPlusClient
    {
        /// <summary>
        /// Detect and analyze human faces within the image that you provided.
        /// Detect API can detect all the faces within the image. Each detected face gets its face_token, which can be used in follow-up analysis and operations. With a Standard API Key, you can specify a rectangle area within the image to perform face detection.
        /// Detect API can analyze detected faces directly, providing face landmarks and attributes information. With a Free API Key, only the 5 largest faces by its bounding box size can be analyzed, while you can use Face Analyze API to analyze the rest faces. With a Standard API Key, you can analyze all the detected faces.
        /// </summary>
        /// <param name="request">Request for detecting</param>
        /// <exception cref="HttpRequestException"></exception>
        /// <returns>Detect result</returns>
        Task<FaceDetectResponse> FaceDetectAsync(FaceDetectRequest request);

        /// <summary>
        /// Compare two faces and decide whether they are from the same person. You can upload image file or use face_token for face comparing. For image upload, the biggest face by the size of bounding box within the image will be used. For face_token, you shall get it by using Detect API.
        /// </summary>
        /// <param name="request">Request for comparing</param>
        /// <returns>Response of comparing</returns>
        /// <exception cref="HttpRequestException"></exception>
        Task<FaceCompareResponse> FaceCompareAsync(FaceCompareRequest request);

        /// <summary>
        /// Find one or more most similar faces from Faceset, to a new face. You can upload image file or use face_token for face searching. For image upload, the biggest face by the size of bounding box within the image will be used. For face_token, you shall get it by using Detect API.
        /// </summary>
        /// <param name="request">Request for search</param>
        /// <returns>Response of searching</returns>
        Task<FaceSearchResponse> FaceSearchAsync(FaceSearchRequest request);

        /// <summary>
        /// Get face landmarks and attributes by passing its face_token which you can get from Detect API. Face Analyze API allows you to process  up to 5 face_token at a time.
        /// </summary>
        /// <param name="request">Request for analyze</param>
        /// <returns>Response from face analyze</returns>
        Task<FaceAnalyzeResponse> FaceAnalyzeAsync(FaceAnalyzeRequest request);

        /// <summary>
        /// Get information related to a face by passing its face_token which you can get from Detect API. Face related information includes image_id and FaceSet which it belongs to.
        /// </summary>
        /// <param name="request">Request for face get detail</param>
        /// <returns>Response from face get detail</returns>
        Task<FaceGetDetailResponse> FaceGetDetailAsync(FaceGetDetailRequest request);

        Task<FaceSetUserIdResponse> FaceSetUserIdAsync(FaceSetUserIdRequest request);

        /// <summary>
        /// Create a face collection called FaceSet to store face_token. One FaceSet can hold up to 10,000 face_token.
        /// </summary>
        /// <param name="request">Request for create faceSet</param>
        /// <returns>Response of face set creating</returns>
        Task<FaceSetAddOrCreateFaceResponse> FaceSetCreateAsync(FaceSetCreateRequest request);

        /// <summary>
        /// Add face_token into an existing FaceSet. One FaceSet can hold up to 10000 face_token.
        /// </summary>
        /// <param name="request">Request for add face to faceSet</param>
        /// <returns>Response of adding face to faceSet</returns>
        Task<FaceSetAddOrCreateFaceResponse> FaceSetAddFaceAsync(FaceSetAddOrRemoveFaceRequest request);

        /// <summary>
        /// Remove all or part of face_token within a FaceSet.
        /// </summary>
        /// <param name="request">Request for remove face from face se</param>
        /// <returns>Response of removing face from face set</returns>
        Task<FaceSetRemoveFaceResponse> FaceSetRemoveFaceAsync(FaceSetAddOrRemoveFaceRequest request);

        /// <summary>
        /// Delete a FaceSet.
        /// </summary>
        /// <param name="request">Request for delete</param>
        /// <returns>Response from deleting</returns>
        Task<FaceSetDeleteResponse> FaceSetDeleteAsync(FaceSetDeleteRequest request);

        /// <summary>
        /// Get all the FaceSet.
        /// Get the list of FaceSet under an API Key, as well as information such as faceset_token, outer_id, display_name, and tags.
        /// </summary>
        /// <param name="request">Request for get faceSets</param>
        /// <returns>Response of getting all face sets</returns>
        Task<FaceSetGetFaceSetsResponse> FaceSetGetFaceSetAsync(FaceSetGetFaceSetsRequest request);

        /// <summary>
        /// Get details about a FaceSet, including information such as faceset_token, outer_id, display_name, as well as the number and list of face_token within this FaceSet.
        /// </summary>
        /// <param name="request">Request for get detail of face set</param>
        /// <returns>Response of getting all face set</returns>
        Task<FaceSetGetDetailResponse> FaceSetGetDetailAsync(FaceSetGetDetailRequest request);

        /// <summary>
        /// Update the attributes of a FaceSet.
        /// </summary>
        /// <param name="request">Request for update face set</param>
        /// <returns>Response of updating face set</returns>
        Task<FaceSetUpdateResponse> FaceSetUpdateAsync(FaceSetUpdateRequest request);
    }
}