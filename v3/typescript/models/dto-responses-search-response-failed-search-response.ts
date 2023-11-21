/*
NewsCatcher-V3 Production API

<img src='https://uploads-ssl.webflow.com/6429857b17973b636c2195c5/646c6f1eb774ff2f2997bec5_newscatcher_.svg' width='286' height='35' /> <br>  <br>Visit our website  <a href='https://newscatcherapi.com'>https://newscatcherapi.com</a> <br> <p style=\"color: red\"><b><em> This is a Testing Phase API. Please use it for testing purposes only. </em></b></p> <br>

The version of the OpenAPI document: Beta-3.0.0
Contact: maksym@newscatcherapi.com

NOTE: This file is auto generated by Konfig (https://konfigthis.com).
*/
import type * as buffer from "buffer"

import { DtoResponsesSearchResponseArticleResult } from './dto-responses-search-response-article-result';

/**
 * 
 * @export
 * @interface DtoResponsesSearchResponseFailedSearchResponse
 */
export interface DtoResponsesSearchResponseFailedSearchResponse {
    /**
     * 
     * @type {string}
     * @memberof DtoResponsesSearchResponseFailedSearchResponse
     */
    'status'?: string;
    /**
     * 
     * @type {number}
     * @memberof DtoResponsesSearchResponseFailedSearchResponse
     */
    'total_hits'?: number;
    /**
     * 
     * @type {number}
     * @memberof DtoResponsesSearchResponseFailedSearchResponse
     */
    'page'?: number;
    /**
     * 
     * @type {number}
     * @memberof DtoResponsesSearchResponseFailedSearchResponse
     */
    'total_pages'?: number;
    /**
     * 
     * @type {number}
     * @memberof DtoResponsesSearchResponseFailedSearchResponse
     */
    'page_size'?: number;
    /**
     * 
     * @type {Array<DtoResponsesSearchResponseArticleResult>}
     * @memberof DtoResponsesSearchResponseFailedSearchResponse
     */
    'articles'?: Array<DtoResponsesSearchResponseArticleResult>;
    /**
     * 
     * @type {object}
     * @memberof DtoResponsesSearchResponseFailedSearchResponse
     */
    'user_input': object;
}

