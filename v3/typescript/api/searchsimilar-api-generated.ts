/* tslint:disable */
/* eslint-disable */
/*
NewsCatcher-V3 Production API

<img src='https://uploads-ssl.webflow.com/6429857b17973b636c2195c5/646c6f1eb774ff2f2997bec5_newscatcher_.svg' width='286' height='35' /> <br>  <br>Visit our website  <a href='https://newscatcherapi.com'>https://newscatcherapi.com</a> <br> <p style=\"color: red\"><b><em> This is a Testing Phase API. Please use it for testing purposes only. </em></b></p> <br>

The version of the OpenAPI document: Beta-3.0.0
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
import { From } from '../models';
// @ts-ignore
import { HTTPValidationError } from '../models';
// @ts-ignore
import { LocationPropertyInner } from '../models';
// @ts-ignore
import { MoreLikeThisRequest } from '../models';
// @ts-ignore
import { SearchSimilarGetResponse } from '../models';
// @ts-ignore
import { SearchSimilarPostResponse } from '../models';
// @ts-ignore
import { To } from '../models';
// @ts-ignore
import { ValidationError } from '../models';
import { paginate } from "../pagination/paginate";
import type * as buffer from "buffer"
import { requestBeforeHook } from '../requestBeforeHook';
/**
 * SearchsimilarApi - axios parameter creator
 * @export
 */
export const SearchsimilarApiAxiosParamCreator = function (configuration?: Configuration) {
    return {
        /**
         * This endpoint returns a list of articles that are similar to the query provided. You also have the option to get similar articles for the results of a search.
         * @summary [Get] Search For Similar Articles Request
         * @param {string} q 
         * @param {string} [searchIn] 
         * @param {boolean} [includeSimilarDocuments] 
         * @param {number} [similarDocumentsNumber] 
         * @param {string} [similarDocumentsFields] 
         * @param {string} [predefinedSources] 
         * @param {string} [sources] 
         * @param {string} [notSources] 
         * @param {string} [lang] 
         * @param {string} [notLang] 
         * @param {string} [countries] 
         * @param {string} [notCountries] 
         * @param {From} [from] 
         * @param {To} [to] 
         * @param {boolean} [byParseDate] 
         * @param {string} [publishedDatePrecision] 
         * @param {string} [sortBy] 
         * @param {string} [rankedOnly] 
         * @param {number} [fromRank] 
         * @param {number} [toRank] 
         * @param {boolean} [isHeadline] 
         * @param {boolean} [isPaidContent] 
         * @param {string} [parentUrl] 
         * @param {string} [allLinks] 
         * @param {string} [allDomainLinks] 
         * @param {number} [wordCountMin] 
         * @param {number} [wordCountMax] 
         * @param {number} [page] 
         * @param {number} [pageSize] 
         * @param {boolean} [includeNlpData] 
         * @param {boolean} [hasNlp] 
         * @param {string} [theme] 
         * @param {string} [nerName] 
         * @param {number} [titleSentimentMin] 
         * @param {number} [titleSentimentMax] 
         * @param {number} [contentSentimentMin] 
         * @param {number} [contentSentimentMax] 
         * @param {*} [options] Override http request option.
         * @throws {RequiredError}
         */
        get: async (q: string, searchIn?: string, includeSimilarDocuments?: boolean, similarDocumentsNumber?: number, similarDocumentsFields?: string, predefinedSources?: string, sources?: string, notSources?: string, lang?: string, notLang?: string, countries?: string, notCountries?: string, from?: From, to?: To, byParseDate?: boolean, publishedDatePrecision?: string, sortBy?: string, rankedOnly?: string, fromRank?: number, toRank?: number, isHeadline?: boolean, isPaidContent?: boolean, parentUrl?: string, allLinks?: string, allDomainLinks?: string, wordCountMin?: number, wordCountMax?: number, page?: number, pageSize?: number, includeNlpData?: boolean, hasNlp?: boolean, theme?: string, nerName?: string, titleSentimentMin?: number, titleSentimentMax?: number, contentSentimentMin?: number, contentSentimentMax?: number, options: AxiosRequestConfig = {}): Promise<RequestArgs> => {
            // verify required parameter 'q' is not null or undefined
            assertParamExists('get', 'q', q)
            const localVarPath = `/api/search_similar`;
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
            await setApiKeyToObject({ object: localVarHeaderParameter, keyParamName: "x-api-token", configuration })
            if (q !== undefined) {
                localVarQueryParameter['q'] = q;
            }

            if (searchIn !== undefined) {
                localVarQueryParameter['search_in'] = searchIn;
            }

            if (includeSimilarDocuments !== undefined) {
                localVarQueryParameter['include_similar_documents'] = includeSimilarDocuments;
            }

            if (similarDocumentsNumber !== undefined) {
                localVarQueryParameter['similar_documents_number'] = similarDocumentsNumber;
            }

            if (similarDocumentsFields !== undefined) {
                localVarQueryParameter['similar_documents_fields'] = similarDocumentsFields;
            }

            if (predefinedSources !== undefined) {
                localVarQueryParameter['predefined_sources'] = predefinedSources;
            }

            if (sources !== undefined) {
                localVarQueryParameter['sources'] = sources;
            }

            if (notSources !== undefined) {
                localVarQueryParameter['not_sources'] = notSources;
            }

            if (lang !== undefined) {
                localVarQueryParameter['lang'] = lang;
            }

            if (notLang !== undefined) {
                localVarQueryParameter['not_lang'] = notLang;
            }

            if (countries !== undefined) {
                localVarQueryParameter['countries'] = countries;
            }

            if (notCountries !== undefined) {
                localVarQueryParameter['not_countries'] = notCountries;
            }

            if (from !== undefined) {
                localVarQueryParameter['from_'] = from;
            }

            if (to !== undefined) {
                localVarQueryParameter['to_'] = to;
            }

            if (byParseDate !== undefined) {
                localVarQueryParameter['by_parse_date'] = byParseDate;
            }

            if (publishedDatePrecision !== undefined) {
                localVarQueryParameter['published_date_precision'] = publishedDatePrecision;
            }

            if (sortBy !== undefined) {
                localVarQueryParameter['sort_by'] = sortBy;
            }

            if (rankedOnly !== undefined) {
                localVarQueryParameter['ranked_only'] = rankedOnly;
            }

            if (fromRank !== undefined) {
                localVarQueryParameter['from_rank'] = fromRank;
            }

            if (toRank !== undefined) {
                localVarQueryParameter['to_rank'] = toRank;
            }

            if (isHeadline !== undefined) {
                localVarQueryParameter['is_headline'] = isHeadline;
            }

            if (isPaidContent !== undefined) {
                localVarQueryParameter['is_paid_content'] = isPaidContent;
            }

            if (parentUrl !== undefined) {
                localVarQueryParameter['parent_url'] = parentUrl;
            }

            if (allLinks !== undefined) {
                localVarQueryParameter['all_links'] = allLinks;
            }

            if (allDomainLinks !== undefined) {
                localVarQueryParameter['all_domain_links'] = allDomainLinks;
            }

            if (wordCountMin !== undefined) {
                localVarQueryParameter['word_count_min'] = wordCountMin;
            }

            if (wordCountMax !== undefined) {
                localVarQueryParameter['word_count_max'] = wordCountMax;
            }

            if (page !== undefined) {
                localVarQueryParameter['page'] = page;
            }

            if (pageSize !== undefined) {
                localVarQueryParameter['page_size'] = pageSize;
            }

            if (includeNlpData !== undefined) {
                localVarQueryParameter['include_nlp_data'] = includeNlpData;
            }

            if (hasNlp !== undefined) {
                localVarQueryParameter['has_nlp'] = hasNlp;
            }

            if (theme !== undefined) {
                localVarQueryParameter['theme'] = theme;
            }

            if (nerName !== undefined) {
                localVarQueryParameter['ner_name'] = nerName;
            }

            if (titleSentimentMin !== undefined) {
                localVarQueryParameter['title_sentiment_min'] = titleSentimentMin;
            }

            if (titleSentimentMax !== undefined) {
                localVarQueryParameter['title_sentiment_max'] = titleSentimentMax;
            }

            if (contentSentimentMin !== undefined) {
                localVarQueryParameter['content_sentiment_min'] = contentSentimentMin;
            }

            if (contentSentimentMax !== undefined) {
                localVarQueryParameter['content_sentiment_max'] = contentSentimentMax;
            }


    
            let headersFromBaseOptions = baseOptions && baseOptions.headers ? baseOptions.headers : {};
            localVarRequestOptions.headers = {...localVarHeaderParameter, ...headersFromBaseOptions, ...options.headers};
            requestBeforeHook({
                queryParameters: localVarQueryParameter,
                requestConfig: localVarRequestOptions,
                path: localVarPath,
                configuration
            });

            setSearchParams(localVarUrlObj, localVarQueryParameter);
            return {
                url: toPathString(localVarUrlObj),
                options: localVarRequestOptions,
            };
        },
        /**
         * This endpoint returns a list of articles that are similar to the query provided. You also have the option to get similar articles for the results of a search.
         * @summary [Post] Search For Similar Articles Request
         * @param {MoreLikeThisRequest} moreLikeThisRequest 
         * @param {*} [options] Override http request option.
         * @throws {RequiredError}
         */
        post: async (moreLikeThisRequest: MoreLikeThisRequest, options: AxiosRequestConfig = {}): Promise<RequestArgs> => {
            // verify required parameter 'moreLikeThisRequest' is not null or undefined
            assertParamExists('post', 'moreLikeThisRequest', moreLikeThisRequest)
            const localVarPath = `/api/search_similar`;
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
            await setApiKeyToObject({ object: localVarHeaderParameter, keyParamName: "x-api-token", configuration })

    
            localVarHeaderParameter['Content-Type'] = 'application/json';


            let headersFromBaseOptions = baseOptions && baseOptions.headers ? baseOptions.headers : {};
            localVarRequestOptions.headers = {...localVarHeaderParameter, ...headersFromBaseOptions, ...options.headers};
            requestBeforeHook({
                requestBody: moreLikeThisRequest,
                queryParameters: localVarQueryParameter,
                requestConfig: localVarRequestOptions,
                path: localVarPath,
                configuration
            });
            localVarRequestOptions.data = serializeDataIfNeeded(moreLikeThisRequest, localVarRequestOptions, configuration)

            setSearchParams(localVarUrlObj, localVarQueryParameter);
            return {
                url: toPathString(localVarUrlObj),
                options: localVarRequestOptions,
            };
        },
    }
};

/**
 * SearchsimilarApi - functional programming interface
 * @export
 */
export const SearchsimilarApiFp = function(configuration?: Configuration) {
    const localVarAxiosParamCreator = SearchsimilarApiAxiosParamCreator(configuration)
    return {
        /**
         * This endpoint returns a list of articles that are similar to the query provided. You also have the option to get similar articles for the results of a search.
         * @summary [Get] Search For Similar Articles Request
         * @param {SearchsimilarApiGetRequest} requestParameters Request parameters.
         * @param {*} [options] Override http request option.
         * @throws {RequiredError}
         */
        async get(requestParameters: SearchsimilarApiGetRequest, options?: AxiosRequestConfig): Promise<(axios?: AxiosInstance, basePath?: string) => AxiosPromise<SearchSimilarGetResponse>> {
            const localVarAxiosArgs = await localVarAxiosParamCreator.get(requestParameters.q, requestParameters.searchIn, requestParameters.includeSimilarDocuments, requestParameters.similarDocumentsNumber, requestParameters.similarDocumentsFields, requestParameters.predefinedSources, requestParameters.sources, requestParameters.notSources, requestParameters.lang, requestParameters.notLang, requestParameters.countries, requestParameters.notCountries, requestParameters.from, requestParameters.to, requestParameters.byParseDate, requestParameters.publishedDatePrecision, requestParameters.sortBy, requestParameters.rankedOnly, requestParameters.fromRank, requestParameters.toRank, requestParameters.isHeadline, requestParameters.isPaidContent, requestParameters.parentUrl, requestParameters.allLinks, requestParameters.allDomainLinks, requestParameters.wordCountMin, requestParameters.wordCountMax, requestParameters.page, requestParameters.pageSize, requestParameters.includeNlpData, requestParameters.hasNlp, requestParameters.theme, requestParameters.nerName, requestParameters.titleSentimentMin, requestParameters.titleSentimentMax, requestParameters.contentSentimentMin, requestParameters.contentSentimentMax, options);
            return createRequestFunction(localVarAxiosArgs, globalAxios, BASE_PATH, configuration);
        },
        /**
         * This endpoint returns a list of articles that are similar to the query provided. You also have the option to get similar articles for the results of a search.
         * @summary [Post] Search For Similar Articles Request
         * @param {SearchsimilarApiPostRequest} requestParameters Request parameters.
         * @param {*} [options] Override http request option.
         * @throws {RequiredError}
         */
        async post(requestParameters: SearchsimilarApiPostRequest, options?: AxiosRequestConfig): Promise<(axios?: AxiosInstance, basePath?: string) => AxiosPromise<SearchSimilarPostResponse>> {
            const localVarAxiosArgs = await localVarAxiosParamCreator.post(requestParameters, options);
            return createRequestFunction(localVarAxiosArgs, globalAxios, BASE_PATH, configuration);
        },
    }
};

/**
 * SearchsimilarApi - factory interface
 * @export
 */
export const SearchsimilarApiFactory = function (configuration?: Configuration, basePath?: string, axios?: AxiosInstance) {
    const localVarFp = SearchsimilarApiFp(configuration)
    return {
        /**
         * This endpoint returns a list of articles that are similar to the query provided. You also have the option to get similar articles for the results of a search.
         * @summary [Get] Search For Similar Articles Request
         * @param {SearchsimilarApiGetRequest} requestParameters Request parameters.
         * @param {*} [options] Override http request option.
         * @throws {RequiredError}
         */
        get(requestParameters: SearchsimilarApiGetRequest, options?: AxiosRequestConfig): AxiosPromise<SearchSimilarGetResponse> {
            return localVarFp.get(requestParameters, options).then((request) => request(axios, basePath));
        },
        /**
         * This endpoint returns a list of articles that are similar to the query provided. You also have the option to get similar articles for the results of a search.
         * @summary [Post] Search For Similar Articles Request
         * @param {SearchsimilarApiPostRequest} requestParameters Request parameters.
         * @param {*} [options] Override http request option.
         * @throws {RequiredError}
         */
        post(requestParameters: SearchsimilarApiPostRequest, options?: AxiosRequestConfig): AxiosPromise<SearchSimilarPostResponse> {
            return localVarFp.post(requestParameters, options).then((request) => request(axios, basePath));
        },
    };
};

/**
 * Request parameters for get operation in SearchsimilarApi.
 * @export
 * @interface SearchsimilarApiGetRequest
 */
export type SearchsimilarApiGetRequest = {
    
    /**
    * 
    * @type {string}
    * @memberof SearchsimilarApiGet
    */
    readonly q: string
    
    /**
    * 
    * @type {string}
    * @memberof SearchsimilarApiGet
    */
    readonly searchIn?: string
    
    /**
    * 
    * @type {boolean}
    * @memberof SearchsimilarApiGet
    */
    readonly includeSimilarDocuments?: boolean
    
    /**
    * 
    * @type {number}
    * @memberof SearchsimilarApiGet
    */
    readonly similarDocumentsNumber?: number
    
    /**
    * 
    * @type {string}
    * @memberof SearchsimilarApiGet
    */
    readonly similarDocumentsFields?: string
    
    /**
    * 
    * @type {string}
    * @memberof SearchsimilarApiGet
    */
    readonly predefinedSources?: string
    
    /**
    * 
    * @type {string}
    * @memberof SearchsimilarApiGet
    */
    readonly sources?: string
    
    /**
    * 
    * @type {string}
    * @memberof SearchsimilarApiGet
    */
    readonly notSources?: string
    
    /**
    * 
    * @type {string}
    * @memberof SearchsimilarApiGet
    */
    readonly lang?: string
    
    /**
    * 
    * @type {string}
    * @memberof SearchsimilarApiGet
    */
    readonly notLang?: string
    
    /**
    * 
    * @type {string}
    * @memberof SearchsimilarApiGet
    */
    readonly countries?: string
    
    /**
    * 
    * @type {string}
    * @memberof SearchsimilarApiGet
    */
    readonly notCountries?: string
    
    /**
    * 
    * @type {From}
    * @memberof SearchsimilarApiGet
    */
    readonly from?: From
    
    /**
    * 
    * @type {To}
    * @memberof SearchsimilarApiGet
    */
    readonly to?: To
    
    /**
    * 
    * @type {boolean}
    * @memberof SearchsimilarApiGet
    */
    readonly byParseDate?: boolean
    
    /**
    * 
    * @type {string}
    * @memberof SearchsimilarApiGet
    */
    readonly publishedDatePrecision?: string
    
    /**
    * 
    * @type {string}
    * @memberof SearchsimilarApiGet
    */
    readonly sortBy?: string
    
    /**
    * 
    * @type {string}
    * @memberof SearchsimilarApiGet
    */
    readonly rankedOnly?: string
    
    /**
    * 
    * @type {number}
    * @memberof SearchsimilarApiGet
    */
    readonly fromRank?: number
    
    /**
    * 
    * @type {number}
    * @memberof SearchsimilarApiGet
    */
    readonly toRank?: number
    
    /**
    * 
    * @type {boolean}
    * @memberof SearchsimilarApiGet
    */
    readonly isHeadline?: boolean
    
    /**
    * 
    * @type {boolean}
    * @memberof SearchsimilarApiGet
    */
    readonly isPaidContent?: boolean
    
    /**
    * 
    * @type {string}
    * @memberof SearchsimilarApiGet
    */
    readonly parentUrl?: string
    
    /**
    * 
    * @type {string}
    * @memberof SearchsimilarApiGet
    */
    readonly allLinks?: string
    
    /**
    * 
    * @type {string}
    * @memberof SearchsimilarApiGet
    */
    readonly allDomainLinks?: string
    
    /**
    * 
    * @type {number}
    * @memberof SearchsimilarApiGet
    */
    readonly wordCountMin?: number
    
    /**
    * 
    * @type {number}
    * @memberof SearchsimilarApiGet
    */
    readonly wordCountMax?: number
    
    /**
    * 
    * @type {number}
    * @memberof SearchsimilarApiGet
    */
    readonly page?: number
    
    /**
    * 
    * @type {number}
    * @memberof SearchsimilarApiGet
    */
    readonly pageSize?: number
    
    /**
    * 
    * @type {boolean}
    * @memberof SearchsimilarApiGet
    */
    readonly includeNlpData?: boolean
    
    /**
    * 
    * @type {boolean}
    * @memberof SearchsimilarApiGet
    */
    readonly hasNlp?: boolean
    
    /**
    * 
    * @type {string}
    * @memberof SearchsimilarApiGet
    */
    readonly theme?: string
    
    /**
    * 
    * @type {string}
    * @memberof SearchsimilarApiGet
    */
    readonly nerName?: string
    
    /**
    * 
    * @type {number}
    * @memberof SearchsimilarApiGet
    */
    readonly titleSentimentMin?: number
    
    /**
    * 
    * @type {number}
    * @memberof SearchsimilarApiGet
    */
    readonly titleSentimentMax?: number
    
    /**
    * 
    * @type {number}
    * @memberof SearchsimilarApiGet
    */
    readonly contentSentimentMin?: number
    
    /**
    * 
    * @type {number}
    * @memberof SearchsimilarApiGet
    */
    readonly contentSentimentMax?: number
    
}

/**
 * Request parameters for post operation in SearchsimilarApi.
 * @export
 * @interface SearchsimilarApiPostRequest
 */
export type SearchsimilarApiPostRequest = {
    
} & MoreLikeThisRequest

/**
 * SearchsimilarApiGenerated - object-oriented interface
 * @export
 * @class SearchsimilarApiGenerated
 * @extends {BaseAPI}
 */
export class SearchsimilarApiGenerated extends BaseAPI {
    /**
     * This endpoint returns a list of articles that are similar to the query provided. You also have the option to get similar articles for the results of a search.
     * @summary [Get] Search For Similar Articles Request
     * @param {SearchsimilarApiGetRequest} requestParameters Request parameters.
     * @param {*} [options] Override http request option.
     * @throws {RequiredError}
     * @memberof SearchsimilarApiGenerated
     */
    public get(requestParameters: SearchsimilarApiGetRequest, options?: AxiosRequestConfig) {
        return SearchsimilarApiFp(this.configuration).get(requestParameters, options).then((request) => request(this.axios, this.basePath));
    }

    /**
     * This endpoint returns a list of articles that are similar to the query provided. You also have the option to get similar articles for the results of a search.
     * @summary [Post] Search For Similar Articles Request
     * @param {SearchsimilarApiPostRequest} requestParameters Request parameters.
     * @param {*} [options] Override http request option.
     * @throws {RequiredError}
     * @memberof SearchsimilarApiGenerated
     */
    public post(requestParameters: SearchsimilarApiPostRequest, options?: AxiosRequestConfig) {
        return SearchsimilarApiFp(this.configuration).post(requestParameters, options).then((request) => request(this.axios, this.basePath));
    }
}
