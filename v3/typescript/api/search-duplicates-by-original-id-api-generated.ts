/* tslint:disable */
/* eslint-disable */
/*
NewsCatcher-V3 Production API

<img src='https://uploads-ssl.webflow.com/6429857b17973b636c2195c5/646c6f1eb774ff2f2997bec5_newscatcher_.svg' width='286' height='35' /> <br>  <br>Visit our website  <a href='https://newscatcherapi.com'>https://newscatcherapi.com</a>

The version of the OpenAPI document: 3.2.16
Contact: maksym@newscatcherapi.com

NOTE: This file is auto generated by Konfig (https://konfigthis.com).
*/

import globalAxios, { AxiosPromise, AxiosInstance, AxiosRequestConfig } from 'axios';
import { Configuration } from '../configuration';
// Some imports not used depending on template conditions
// @ts-ignore
import { DUMMY_BASE_URL, assertParamExists, setApiKeyToObject, setBasicAuthToObject, setBearerAuthToObject, setSearchParams, serializeDataIfNeeded, toPathString, createRequestFunction, isBrowser } from '../common';
// @ts-ignore
import { BASE_PATH, COLLECTION_FORMATS, RequestArgs, BaseAPI, RequiredError } from '../base';
// @ts-ignore
import { DuplicatesByOriginalIdRequest } from '../models';
// @ts-ignore
import { HTTPValidationError } from '../models';
// @ts-ignore
import { SearchduplicatesbyoriginalidGetResponse } from '../models';
// @ts-ignore
import { SearchduplicatesbyoriginalidPostResponse } from '../models';
import { paginate } from "../pagination/paginate";
import type * as buffer from "buffer"
import { requestBeforeHook } from '../requestBeforeHook';
/**
 * SearchDuplicatesByOriginalIdApi - axios parameter creator
 * @export
 */
export const SearchDuplicatesByOriginalIdApiAxiosParamCreator = function (configuration?: Configuration) {
    return {
        /**
         * This endpoint allows you to search for duplicate articles by original article id.
         * @summary [Get] Search Duplicate Articles For Articles Request
         * @param {string} originalArticleId 
         * @param {number} [page] 
         * @param {number} [pageSize] 
         * @param {*} [options] Override http request option.
         * @throws {RequiredError}
         */
        get: async (originalArticleId: string, page?: number, pageSize?: number, options: AxiosRequestConfig = {}): Promise<RequestArgs> => {
            // verify required parameter 'originalArticleId' is not null or undefined
            assertParamExists('get', 'originalArticleId', originalArticleId)
            const localVarPath = `/api/search_duplicates_by_original_id`;
            // use dummy base URL string because the URL constructor only accepts absolute URLs.
            const localVarUrlObj = new URL(localVarPath, DUMMY_BASE_URL);
            let baseOptions;
            if (configuration) {
                baseOptions = configuration.baseOptions;
            }

            const localVarRequestOptions: AxiosRequestConfig = { method: 'GET', ...baseOptions, ...options};
            const localVarHeaderParameter = configuration && !isBrowser() ? { "User-Agent": configuration.userAgent } : {} as any;
            const localVarQueryParameter = {} as any;

            // authentication apiKey required
            await setApiKeyToObject({ object: localVarHeaderParameter, key: "x-api-token", keyParamName: "xApiToken", configuration })
            if (originalArticleId !== undefined) {
                localVarQueryParameter['original_article_id'] = originalArticleId;
            }

            if (page !== undefined) {
                localVarQueryParameter['page'] = page;
            }

            if (pageSize !== undefined) {
                localVarQueryParameter['page_size'] = pageSize;
            }


    
            let headersFromBaseOptions = baseOptions && baseOptions.headers ? baseOptions.headers : {};
            localVarRequestOptions.headers = {...localVarHeaderParameter, ...headersFromBaseOptions, ...options.headers};
            requestBeforeHook({
                queryParameters: localVarQueryParameter,
                requestConfig: localVarRequestOptions,
                path: localVarPath,
                configuration,
                pathTemplate: '/api/search_duplicates_by_original_id',
                httpMethod: 'GET'
            });

            setSearchParams(localVarUrlObj, localVarQueryParameter);
            return {
                url: toPathString(localVarUrlObj),
                options: localVarRequestOptions,
            };
        },
        /**
         * This endpoint allows you to search for duplicate articles by original article id.
         * @summary [Post] Search Duplicate Articles For Articles Request
         * @param {DuplicatesByOriginalIdRequest} duplicatesByOriginalIdRequest 
         * @param {*} [options] Override http request option.
         * @throws {RequiredError}
         */
        post: async (duplicatesByOriginalIdRequest: DuplicatesByOriginalIdRequest, options: AxiosRequestConfig = {}): Promise<RequestArgs> => {
            // verify required parameter 'duplicatesByOriginalIdRequest' is not null or undefined
            assertParamExists('post', 'duplicatesByOriginalIdRequest', duplicatesByOriginalIdRequest)
            const localVarPath = `/api/search_duplicates_by_original_id`;
            // use dummy base URL string because the URL constructor only accepts absolute URLs.
            const localVarUrlObj = new URL(localVarPath, DUMMY_BASE_URL);
            let baseOptions;
            if (configuration) {
                baseOptions = configuration.baseOptions;
            }

            const localVarRequestOptions: AxiosRequestConfig = { method: 'POST', ...baseOptions, ...options};
            const localVarHeaderParameter = configuration && !isBrowser() ? { "User-Agent": configuration.userAgent } : {} as any;
            const localVarQueryParameter = {} as any;

            // authentication apiKey required
            await setApiKeyToObject({ object: localVarHeaderParameter, key: "x-api-token", keyParamName: "xApiToken", configuration })

    
            localVarHeaderParameter['Content-Type'] = 'application/json';


            let headersFromBaseOptions = baseOptions && baseOptions.headers ? baseOptions.headers : {};
            localVarRequestOptions.headers = {...localVarHeaderParameter, ...headersFromBaseOptions, ...options.headers};
            requestBeforeHook({
                requestBody: duplicatesByOriginalIdRequest,
                queryParameters: localVarQueryParameter,
                requestConfig: localVarRequestOptions,
                path: localVarPath,
                configuration,
                pathTemplate: '/api/search_duplicates_by_original_id',
                httpMethod: 'POST'
            });
            localVarRequestOptions.data = serializeDataIfNeeded(duplicatesByOriginalIdRequest, localVarRequestOptions, configuration)

            setSearchParams(localVarUrlObj, localVarQueryParameter);
            return {
                url: toPathString(localVarUrlObj),
                options: localVarRequestOptions,
            };
        },
    }
};

/**
 * SearchDuplicatesByOriginalIdApi - functional programming interface
 * @export
 */
export const SearchDuplicatesByOriginalIdApiFp = function(configuration?: Configuration) {
    const localVarAxiosParamCreator = SearchDuplicatesByOriginalIdApiAxiosParamCreator(configuration)
    return {
        /**
         * This endpoint allows you to search for duplicate articles by original article id.
         * @summary [Get] Search Duplicate Articles For Articles Request
         * @param {SearchDuplicatesByOriginalIdApiGetRequest} requestParameters Request parameters.
         * @param {*} [options] Override http request option.
         * @throws {RequiredError}
         */
        async get(requestParameters: SearchDuplicatesByOriginalIdApiGetRequest, options?: AxiosRequestConfig): Promise<(axios?: AxiosInstance, basePath?: string) => AxiosPromise<SearchduplicatesbyoriginalidGetResponse>> {
            const localVarAxiosArgs = await localVarAxiosParamCreator.get(requestParameters.originalArticleId, requestParameters.page, requestParameters.pageSize, options);
            return createRequestFunction(localVarAxiosArgs, globalAxios, BASE_PATH, configuration);
        },
        /**
         * This endpoint allows you to search for duplicate articles by original article id.
         * @summary [Post] Search Duplicate Articles For Articles Request
         * @param {SearchDuplicatesByOriginalIdApiPostRequest} requestParameters Request parameters.
         * @param {*} [options] Override http request option.
         * @throws {RequiredError}
         */
        async post(requestParameters: SearchDuplicatesByOriginalIdApiPostRequest, options?: AxiosRequestConfig): Promise<(axios?: AxiosInstance, basePath?: string) => AxiosPromise<SearchduplicatesbyoriginalidPostResponse>> {
            const duplicatesByOriginalIdRequest: DuplicatesByOriginalIdRequest = {
                original_article_id: requestParameters.original_article_id,
                page: requestParameters.page,
                page_size: requestParameters.page_size
            };
            const localVarAxiosArgs = await localVarAxiosParamCreator.post(duplicatesByOriginalIdRequest, options);
            return createRequestFunction(localVarAxiosArgs, globalAxios, BASE_PATH, configuration);
        },
    }
};

/**
 * SearchDuplicatesByOriginalIdApi - factory interface
 * @export
 */
export const SearchDuplicatesByOriginalIdApiFactory = function (configuration?: Configuration, basePath?: string, axios?: AxiosInstance) {
    const localVarFp = SearchDuplicatesByOriginalIdApiFp(configuration)
    return {
        /**
         * This endpoint allows you to search for duplicate articles by original article id.
         * @summary [Get] Search Duplicate Articles For Articles Request
         * @param {SearchDuplicatesByOriginalIdApiGetRequest} requestParameters Request parameters.
         * @param {*} [options] Override http request option.
         * @throws {RequiredError}
         */
        get(requestParameters: SearchDuplicatesByOriginalIdApiGetRequest, options?: AxiosRequestConfig): AxiosPromise<SearchduplicatesbyoriginalidGetResponse> {
            return localVarFp.get(requestParameters, options).then((request) => request(axios, basePath));
        },
        /**
         * This endpoint allows you to search for duplicate articles by original article id.
         * @summary [Post] Search Duplicate Articles For Articles Request
         * @param {SearchDuplicatesByOriginalIdApiPostRequest} requestParameters Request parameters.
         * @param {*} [options] Override http request option.
         * @throws {RequiredError}
         */
        post(requestParameters: SearchDuplicatesByOriginalIdApiPostRequest, options?: AxiosRequestConfig): AxiosPromise<SearchduplicatesbyoriginalidPostResponse> {
            return localVarFp.post(requestParameters, options).then((request) => request(axios, basePath));
        },
    };
};

/**
 * Request parameters for get operation in SearchDuplicatesByOriginalIdApi.
 * @export
 * @interface SearchDuplicatesByOriginalIdApiGetRequest
 */
export type SearchDuplicatesByOriginalIdApiGetRequest = {
    
    /**
    * 
    * @type {string}
    * @memberof SearchDuplicatesByOriginalIdApiGet
    */
    readonly originalArticleId: string
    
    /**
    * 
    * @type {number}
    * @memberof SearchDuplicatesByOriginalIdApiGet
    */
    readonly page?: number
    
    /**
    * 
    * @type {number}
    * @memberof SearchDuplicatesByOriginalIdApiGet
    */
    readonly pageSize?: number
    
}

/**
 * Request parameters for post operation in SearchDuplicatesByOriginalIdApi.
 * @export
 * @interface SearchDuplicatesByOriginalIdApiPostRequest
 */
export type SearchDuplicatesByOriginalIdApiPostRequest = {
    
} & DuplicatesByOriginalIdRequest

/**
 * SearchDuplicatesByOriginalIdApiGenerated - object-oriented interface
 * @export
 * @class SearchDuplicatesByOriginalIdApiGenerated
 * @extends {BaseAPI}
 */
export class SearchDuplicatesByOriginalIdApiGenerated extends BaseAPI {
    /**
     * This endpoint allows you to search for duplicate articles by original article id.
     * @summary [Get] Search Duplicate Articles For Articles Request
     * @param {SearchDuplicatesByOriginalIdApiGetRequest} requestParameters Request parameters.
     * @param {*} [options] Override http request option.
     * @throws {RequiredError}
     * @memberof SearchDuplicatesByOriginalIdApiGenerated
     */
    public get(requestParameters: SearchDuplicatesByOriginalIdApiGetRequest, options?: AxiosRequestConfig) {
        return SearchDuplicatesByOriginalIdApiFp(this.configuration).get(requestParameters, options).then((request) => request(this.axios, this.basePath));
    }

    /**
     * This endpoint allows you to search for duplicate articles by original article id.
     * @summary [Post] Search Duplicate Articles For Articles Request
     * @param {SearchDuplicatesByOriginalIdApiPostRequest} requestParameters Request parameters.
     * @param {*} [options] Override http request option.
     * @throws {RequiredError}
     * @memberof SearchDuplicatesByOriginalIdApiGenerated
     */
    public post(requestParameters: SearchDuplicatesByOriginalIdApiPostRequest, options?: AxiosRequestConfig) {
        return SearchDuplicatesByOriginalIdApiFp(this.configuration).post(requestParameters, options).then((request) => request(this.axios, this.basePath));
    }
}