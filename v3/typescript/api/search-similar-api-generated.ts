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
import { From } from '../models';
// @ts-ignore
import { HTTPValidationError } from '../models';
// @ts-ignore
import { MoreLikeThisRequest } from '../models';
// @ts-ignore
import { SearchSimilarGetResponse } from '../models';
// @ts-ignore
import { SearchSimilarPostResponse } from '../models';
// @ts-ignore
import { To } from '../models';
import { paginate } from "../pagination/paginate";
import type * as buffer from "buffer"
import { requestBeforeHook } from '../requestBeforeHook';
/**
 * SearchSimilarApi - axios parameter creator
 * @export
 */
export const SearchSimilarApiAxiosParamCreator = function (configuration?: Configuration) {
    return {
        /**
         * This endpoint returns a list of articles that are similar to the query provided. You also have the option to get similar articles for the results of a search.
         * @summary [Get] Search For Similar Articles Request
         * @param {string} q 
         * @param {string} [searchIn] 
         * @param {boolean} [includeSimilarDocuments] 
         * @param {number} [similarDocumentsNumber] 
         * @param {string} [similarDocumentsFields] 
         * @param {any} [predefinedSources] 
         * @param {any} [sources] 
         * @param {any} [notSources] 
         * @param {any} [lang] 
         * @param {any} [notLang] 
         * @param {any} [countries] 
         * @param {any} [notCountries] 
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
         * @param {any} [parentUrl] 
         * @param {any} [allLinks] 
         * @param {any} [allDomainLinks] 
         * @param {number} [wordCountMin] 
         * @param {number} [wordCountMax] 
         * @param {number} [page] 
         * @param {number} [pageSize] 
         * @param {boolean} [includeNlpData] 
         * @param {boolean} [hasNlp] 
         * @param {string} [theme] 
         * @param {string} [notTheme] 
         * @param {string} [nerName] 
         * @param {number} [titleSentimentMin] 
         * @param {number} [titleSentimentMax] 
         * @param {number} [contentSentimentMin] 
         * @param {number} [contentSentimentMax] 
         * @param {any} [iptcTags] 
         * @param {any} [notIptcTags] 
         * @param {*} [options] Override http request option.
         * @throws {RequiredError}
         */
        get: async (q: string, searchIn?: string, includeSimilarDocuments?: boolean, similarDocumentsNumber?: number, similarDocumentsFields?: string, predefinedSources?: any, sources?: any, notSources?: any, lang?: any, notLang?: any, countries?: any, notCountries?: any, from?: From, to?: To, byParseDate?: boolean, publishedDatePrecision?: string, sortBy?: string, rankedOnly?: string, fromRank?: number, toRank?: number, isHeadline?: boolean, isPaidContent?: boolean, parentUrl?: any, allLinks?: any, allDomainLinks?: any, wordCountMin?: number, wordCountMax?: number, page?: number, pageSize?: number, includeNlpData?: boolean, hasNlp?: boolean, theme?: string, notTheme?: string, nerName?: string, titleSentimentMin?: number, titleSentimentMax?: number, contentSentimentMin?: number, contentSentimentMax?: number, iptcTags?: any, notIptcTags?: any, options: AxiosRequestConfig = {}): Promise<RequestArgs> => {
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
            await setApiKeyToObject({ object: localVarHeaderParameter, key: "x-api-token", keyParamName: "xApiToken", configuration })
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

            if (notTheme !== undefined) {
                localVarQueryParameter['not_theme'] = notTheme;
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

            if (iptcTags !== undefined) {
                localVarQueryParameter['iptc_tags'] = iptcTags;
            }

            if (notIptcTags !== undefined) {
                localVarQueryParameter['not_iptc_tags'] = notIptcTags;
            }


    
            let headersFromBaseOptions = baseOptions && baseOptions.headers ? baseOptions.headers : {};
            localVarRequestOptions.headers = {...localVarHeaderParameter, ...headersFromBaseOptions, ...options.headers};
            requestBeforeHook({
                queryParameters: localVarQueryParameter,
                requestConfig: localVarRequestOptions,
                path: localVarPath,
                configuration,
                pathTemplate: '/api/search_similar',
                httpMethod: 'GET'
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
            await setApiKeyToObject({ object: localVarHeaderParameter, key: "x-api-token", keyParamName: "xApiToken", configuration })

    
            localVarHeaderParameter['Content-Type'] = 'application/json';


            let headersFromBaseOptions = baseOptions && baseOptions.headers ? baseOptions.headers : {};
            localVarRequestOptions.headers = {...localVarHeaderParameter, ...headersFromBaseOptions, ...options.headers};
            requestBeforeHook({
                requestBody: moreLikeThisRequest,
                queryParameters: localVarQueryParameter,
                requestConfig: localVarRequestOptions,
                path: localVarPath,
                configuration,
                pathTemplate: '/api/search_similar',
                httpMethod: 'POST'
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
 * SearchSimilarApi - functional programming interface
 * @export
 */
export const SearchSimilarApiFp = function(configuration?: Configuration) {
    const localVarAxiosParamCreator = SearchSimilarApiAxiosParamCreator(configuration)
    return {
        /**
         * This endpoint returns a list of articles that are similar to the query provided. You also have the option to get similar articles for the results of a search.
         * @summary [Get] Search For Similar Articles Request
         * @param {SearchSimilarApiGetRequest} requestParameters Request parameters.
         * @param {*} [options] Override http request option.
         * @throws {RequiredError}
         */
        async get(requestParameters: SearchSimilarApiGetRequest, options?: AxiosRequestConfig): Promise<(axios?: AxiosInstance, basePath?: string) => AxiosPromise<SearchSimilarGetResponse>> {
            const localVarAxiosArgs = await localVarAxiosParamCreator.get(requestParameters.q, requestParameters.searchIn, requestParameters.includeSimilarDocuments, requestParameters.similarDocumentsNumber, requestParameters.similarDocumentsFields, requestParameters.predefinedSources, requestParameters.sources, requestParameters.notSources, requestParameters.lang, requestParameters.notLang, requestParameters.countries, requestParameters.notCountries, requestParameters.from, requestParameters.to, requestParameters.byParseDate, requestParameters.publishedDatePrecision, requestParameters.sortBy, requestParameters.rankedOnly, requestParameters.fromRank, requestParameters.toRank, requestParameters.isHeadline, requestParameters.isPaidContent, requestParameters.parentUrl, requestParameters.allLinks, requestParameters.allDomainLinks, requestParameters.wordCountMin, requestParameters.wordCountMax, requestParameters.page, requestParameters.pageSize, requestParameters.includeNlpData, requestParameters.hasNlp, requestParameters.theme, requestParameters.notTheme, requestParameters.nerName, requestParameters.titleSentimentMin, requestParameters.titleSentimentMax, requestParameters.contentSentimentMin, requestParameters.contentSentimentMax, requestParameters.iptcTags, requestParameters.notIptcTags, options);
            return createRequestFunction(localVarAxiosArgs, globalAxios, BASE_PATH, configuration);
        },
        /**
         * This endpoint returns a list of articles that are similar to the query provided. You also have the option to get similar articles for the results of a search.
         * @summary [Post] Search For Similar Articles Request
         * @param {SearchSimilarApiPostRequest} requestParameters Request parameters.
         * @param {*} [options] Override http request option.
         * @throws {RequiredError}
         */
        async post(requestParameters: SearchSimilarApiPostRequest, options?: AxiosRequestConfig): Promise<(axios?: AxiosInstance, basePath?: string) => AxiosPromise<SearchSimilarPostResponse>> {
            const moreLikeThisRequest: MoreLikeThisRequest = {
                q: requestParameters.q,
                search_in: requestParameters.search_in,
                include_similar_documents: requestParameters.include_similar_documents,
                similar_documents_number: requestParameters.similar_documents_number,
                similar_documents_fields: requestParameters.similar_documents_fields,
                predefined_sources: requestParameters.predefined_sources,
                sources: requestParameters.sources,
                not_sources: requestParameters.not_sources,
                lang: requestParameters.lang,
                not_lang: requestParameters.not_lang,
                countries: requestParameters.countries,
                not_countries: requestParameters.not_countries,
                from_: requestParameters.from_,
                to_: requestParameters.to_,
                by_parse_date: requestParameters.by_parse_date,
                published_date_precision: requestParameters.published_date_precision,
                sort_by: requestParameters.sort_by,
                ranked_only: requestParameters.ranked_only,
                from_rank: requestParameters.from_rank,
                to_rank: requestParameters.to_rank,
                is_headline: requestParameters.is_headline,
                is_paid_content: requestParameters.is_paid_content,
                parent_url: requestParameters.parent_url,
                all_links: requestParameters.all_links,
                all_domain_links: requestParameters.all_domain_links,
                word_count_min: requestParameters.word_count_min,
                word_count_max: requestParameters.word_count_max,
                page: requestParameters.page,
                page_size: requestParameters.page_size,
                include_nlp_data: requestParameters.include_nlp_data,
                has_nlp: requestParameters.has_nlp,
                theme: requestParameters.theme,
                not_theme: requestParameters.not_theme,
                ner_name: requestParameters.ner_name,
                title_sentiment_min: requestParameters.title_sentiment_min,
                title_sentiment_max: requestParameters.title_sentiment_max,
                content_sentiment_min: requestParameters.content_sentiment_min,
                content_sentiment_max: requestParameters.content_sentiment_max,
                iptc_tags: requestParameters.iptc_tags,
                not_iptc_tags: requestParameters.not_iptc_tags
            };
            const localVarAxiosArgs = await localVarAxiosParamCreator.post(moreLikeThisRequest, options);
            return createRequestFunction(localVarAxiosArgs, globalAxios, BASE_PATH, configuration);
        },
    }
};

/**
 * SearchSimilarApi - factory interface
 * @export
 */
export const SearchSimilarApiFactory = function (configuration?: Configuration, basePath?: string, axios?: AxiosInstance) {
    const localVarFp = SearchSimilarApiFp(configuration)
    return {
        /**
         * This endpoint returns a list of articles that are similar to the query provided. You also have the option to get similar articles for the results of a search.
         * @summary [Get] Search For Similar Articles Request
         * @param {SearchSimilarApiGetRequest} requestParameters Request parameters.
         * @param {*} [options] Override http request option.
         * @throws {RequiredError}
         */
        get(requestParameters: SearchSimilarApiGetRequest, options?: AxiosRequestConfig): AxiosPromise<SearchSimilarGetResponse> {
            return localVarFp.get(requestParameters, options).then((request) => request(axios, basePath));
        },
        /**
         * This endpoint returns a list of articles that are similar to the query provided. You also have the option to get similar articles for the results of a search.
         * @summary [Post] Search For Similar Articles Request
         * @param {SearchSimilarApiPostRequest} requestParameters Request parameters.
         * @param {*} [options] Override http request option.
         * @throws {RequiredError}
         */
        post(requestParameters: SearchSimilarApiPostRequest, options?: AxiosRequestConfig): AxiosPromise<SearchSimilarPostResponse> {
            return localVarFp.post(requestParameters, options).then((request) => request(axios, basePath));
        },
    };
};

/**
 * Request parameters for get operation in SearchSimilarApi.
 * @export
 * @interface SearchSimilarApiGetRequest
 */
export type SearchSimilarApiGetRequest = {
    
    /**
    * 
    * @type {string}
    * @memberof SearchSimilarApiGet
    */
    readonly q: string
    
    /**
    * 
    * @type {string}
    * @memberof SearchSimilarApiGet
    */
    readonly searchIn?: string
    
    /**
    * 
    * @type {boolean}
    * @memberof SearchSimilarApiGet
    */
    readonly includeSimilarDocuments?: boolean
    
    /**
    * 
    * @type {number}
    * @memberof SearchSimilarApiGet
    */
    readonly similarDocumentsNumber?: number
    
    /**
    * 
    * @type {string}
    * @memberof SearchSimilarApiGet
    */
    readonly similarDocumentsFields?: string
    
    /**
    * 
    * @type {any}
    * @memberof SearchSimilarApiGet
    */
    readonly predefinedSources?: any
    
    /**
    * 
    * @type {any}
    * @memberof SearchSimilarApiGet
    */
    readonly sources?: any
    
    /**
    * 
    * @type {any}
    * @memberof SearchSimilarApiGet
    */
    readonly notSources?: any
    
    /**
    * 
    * @type {any}
    * @memberof SearchSimilarApiGet
    */
    readonly lang?: any
    
    /**
    * 
    * @type {any}
    * @memberof SearchSimilarApiGet
    */
    readonly notLang?: any
    
    /**
    * 
    * @type {any}
    * @memberof SearchSimilarApiGet
    */
    readonly countries?: any
    
    /**
    * 
    * @type {any}
    * @memberof SearchSimilarApiGet
    */
    readonly notCountries?: any
    
    /**
    * 
    * @type {From}
    * @memberof SearchSimilarApiGet
    */
    readonly from?: From
    
    /**
    * 
    * @type {To}
    * @memberof SearchSimilarApiGet
    */
    readonly to?: To
    
    /**
    * 
    * @type {boolean}
    * @memberof SearchSimilarApiGet
    */
    readonly byParseDate?: boolean
    
    /**
    * 
    * @type {string}
    * @memberof SearchSimilarApiGet
    */
    readonly publishedDatePrecision?: string
    
    /**
    * 
    * @type {string}
    * @memberof SearchSimilarApiGet
    */
    readonly sortBy?: string
    
    /**
    * 
    * @type {string}
    * @memberof SearchSimilarApiGet
    */
    readonly rankedOnly?: string
    
    /**
    * 
    * @type {number}
    * @memberof SearchSimilarApiGet
    */
    readonly fromRank?: number
    
    /**
    * 
    * @type {number}
    * @memberof SearchSimilarApiGet
    */
    readonly toRank?: number
    
    /**
    * 
    * @type {boolean}
    * @memberof SearchSimilarApiGet
    */
    readonly isHeadline?: boolean
    
    /**
    * 
    * @type {boolean}
    * @memberof SearchSimilarApiGet
    */
    readonly isPaidContent?: boolean
    
    /**
    * 
    * @type {any}
    * @memberof SearchSimilarApiGet
    */
    readonly parentUrl?: any
    
    /**
    * 
    * @type {any}
    * @memberof SearchSimilarApiGet
    */
    readonly allLinks?: any
    
    /**
    * 
    * @type {any}
    * @memberof SearchSimilarApiGet
    */
    readonly allDomainLinks?: any
    
    /**
    * 
    * @type {number}
    * @memberof SearchSimilarApiGet
    */
    readonly wordCountMin?: number
    
    /**
    * 
    * @type {number}
    * @memberof SearchSimilarApiGet
    */
    readonly wordCountMax?: number
    
    /**
    * 
    * @type {number}
    * @memberof SearchSimilarApiGet
    */
    readonly page?: number
    
    /**
    * 
    * @type {number}
    * @memberof SearchSimilarApiGet
    */
    readonly pageSize?: number
    
    /**
    * 
    * @type {boolean}
    * @memberof SearchSimilarApiGet
    */
    readonly includeNlpData?: boolean
    
    /**
    * 
    * @type {boolean}
    * @memberof SearchSimilarApiGet
    */
    readonly hasNlp?: boolean
    
    /**
    * 
    * @type {string}
    * @memberof SearchSimilarApiGet
    */
    readonly theme?: string
    
    /**
    * 
    * @type {string}
    * @memberof SearchSimilarApiGet
    */
    readonly notTheme?: string
    
    /**
    * 
    * @type {string}
    * @memberof SearchSimilarApiGet
    */
    readonly nerName?: string
    
    /**
    * 
    * @type {number}
    * @memberof SearchSimilarApiGet
    */
    readonly titleSentimentMin?: number
    
    /**
    * 
    * @type {number}
    * @memberof SearchSimilarApiGet
    */
    readonly titleSentimentMax?: number
    
    /**
    * 
    * @type {number}
    * @memberof SearchSimilarApiGet
    */
    readonly contentSentimentMin?: number
    
    /**
    * 
    * @type {number}
    * @memberof SearchSimilarApiGet
    */
    readonly contentSentimentMax?: number
    
    /**
    * 
    * @type {any}
    * @memberof SearchSimilarApiGet
    */
    readonly iptcTags?: any
    
    /**
    * 
    * @type {any}
    * @memberof SearchSimilarApiGet
    */
    readonly notIptcTags?: any
    
}

/**
 * Request parameters for post operation in SearchSimilarApi.
 * @export
 * @interface SearchSimilarApiPostRequest
 */
export type SearchSimilarApiPostRequest = {
    
} & MoreLikeThisRequest

/**
 * SearchSimilarApiGenerated - object-oriented interface
 * @export
 * @class SearchSimilarApiGenerated
 * @extends {BaseAPI}
 */
export class SearchSimilarApiGenerated extends BaseAPI {
    /**
     * This endpoint returns a list of articles that are similar to the query provided. You also have the option to get similar articles for the results of a search.
     * @summary [Get] Search For Similar Articles Request
     * @param {SearchSimilarApiGetRequest} requestParameters Request parameters.
     * @param {*} [options] Override http request option.
     * @throws {RequiredError}
     * @memberof SearchSimilarApiGenerated
     */
    public get(requestParameters: SearchSimilarApiGetRequest, options?: AxiosRequestConfig) {
        return SearchSimilarApiFp(this.configuration).get(requestParameters, options).then((request) => request(this.axios, this.basePath));
    }

    /**
     * This endpoint returns a list of articles that are similar to the query provided. You also have the option to get similar articles for the results of a search.
     * @summary [Post] Search For Similar Articles Request
     * @param {SearchSimilarApiPostRequest} requestParameters Request parameters.
     * @param {*} [options] Override http request option.
     * @throws {RequiredError}
     * @memberof SearchSimilarApiGenerated
     */
    public post(requestParameters: SearchSimilarApiPostRequest, options?: AxiosRequestConfig) {
        return SearchSimilarApiFp(this.configuration).post(requestParameters, options).then((request) => request(this.axios, this.basePath));
    }
}
