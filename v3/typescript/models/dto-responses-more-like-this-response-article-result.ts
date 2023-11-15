/*
NewsCatcher-V3 Production API

<img src='https://uploads-ssl.webflow.com/6429857b17973b636c2195c5/646c6f1eb774ff2f2997bec5_newscatcher_.svg' width='286' height='35' /> <br>  <br>Visit our website  <a href='https://newscatcherapi.com'>https://newscatcherapi.com</a> <br> <p style=\"color: red\"><b><em> This is a Testing Phase API. Please use it for testing purposes only. </em></b></p> <br>

The version of the OpenAPI document: Beta-3.0.0
Contact: maksym@newscatcherapi.com

NOTE: This file is auto generated by Konfig (https://konfigthis.com).
*/
import type * as buffer from "buffer"

import { AllDomainLinksProperty } from './all-domain-links-property';
import { AllLinksProperty } from './all-links-property';
import { AuthorsProperty } from './authors-property';
import { JournalistsProperty } from './journalists-property';
import { SimilarDocument } from './similar-document';

/**
 * 
 * @export
 * @interface DtoResponsesMoreLikeThisResponseArticleResult
 */
export interface DtoResponsesMoreLikeThisResponseArticleResult {
    /**
     * 
     * @type {string}
     * @memberof DtoResponsesMoreLikeThisResponseArticleResult
     */
    'title': string;
    /**
     * 
     * @type {string}
     * @memberof DtoResponsesMoreLikeThisResponseArticleResult
     */
    'description'?: string;
    /**
     * 
     * @type {string}
     * @memberof DtoResponsesMoreLikeThisResponseArticleResult
     */
    'author'?: string;
    /**
     * 
     * @type {AuthorsProperty}
     * @memberof DtoResponsesMoreLikeThisResponseArticleResult
     */
    'authors'?: AuthorsProperty;
    /**
     * 
     * @type {JournalistsProperty}
     * @memberof DtoResponsesMoreLikeThisResponseArticleResult
     */
    'journalists'?: JournalistsProperty;
    /**
     * 
     * @type {string}
     * @memberof DtoResponsesMoreLikeThisResponseArticleResult
     */
    'published_date'?: string;
    /**
     * 
     * @type {string}
     * @memberof DtoResponsesMoreLikeThisResponseArticleResult
     */
    'published_date_precision'?: string;
    /**
     * 
     * @type {string}
     * @memberof DtoResponsesMoreLikeThisResponseArticleResult
     */
    'updated_date'?: string;
    /**
     * 
     * @type {string}
     * @memberof DtoResponsesMoreLikeThisResponseArticleResult
     */
    'updated_date_precision'?: string;
    /**
     * 
     * @type {string}
     * @memberof DtoResponsesMoreLikeThisResponseArticleResult
     */
    'parse_date'?: string;
    /**
     * 
     * @type {string}
     * @memberof DtoResponsesMoreLikeThisResponseArticleResult
     */
    'link': string;
    /**
     * 
     * @type {string}
     * @memberof DtoResponsesMoreLikeThisResponseArticleResult
     */
    'domain_url': string;
    /**
     * 
     * @type {string}
     * @memberof DtoResponsesMoreLikeThisResponseArticleResult
     */
    'full_domain_url': string;
    /**
     * 
     * @type {string}
     * @memberof DtoResponsesMoreLikeThisResponseArticleResult
     */
    'name_source'?: string;
    /**
     * 
     * @type {string}
     * @memberof DtoResponsesMoreLikeThisResponseArticleResult
     */
    'is_headline'?: string;
    /**
     * 
     * @type {boolean}
     * @memberof DtoResponsesMoreLikeThisResponseArticleResult
     */
    'paid_content'?: boolean;
    /**
     * 
     * @type {string}
     * @memberof DtoResponsesMoreLikeThisResponseArticleResult
     */
    'extraction_data': string;
    /**
     * 
     * @type {string}
     * @memberof DtoResponsesMoreLikeThisResponseArticleResult
     */
    'country'?: string;
    /**
     * 
     * @type {string}
     * @memberof DtoResponsesMoreLikeThisResponseArticleResult
     */
    'rights'?: string;
    /**
     * 
     * @type {number}
     * @memberof DtoResponsesMoreLikeThisResponseArticleResult
     */
    'rank': number;
    /**
     * 
     * @type {string}
     * @memberof DtoResponsesMoreLikeThisResponseArticleResult
     */
    'media'?: string;
    /**
     * 
     * @type {string}
     * @memberof DtoResponsesMoreLikeThisResponseArticleResult
     */
    'language'?: string;
    /**
     * 
     * @type {string}
     * @memberof DtoResponsesMoreLikeThisResponseArticleResult
     */
    'content': string;
    /**
     * 
     * @type {number}
     * @memberof DtoResponsesMoreLikeThisResponseArticleResult
     */
    'word_count'?: number;
    /**
     * 
     * @type {boolean}
     * @memberof DtoResponsesMoreLikeThisResponseArticleResult
     */
    'is_opinion'?: boolean;
    /**
     * 
     * @type {string}
     * @memberof DtoResponsesMoreLikeThisResponseArticleResult
     */
    'twitter_account'?: string;
    /**
     * 
     * @type {AllLinksProperty}
     * @memberof DtoResponsesMoreLikeThisResponseArticleResult
     */
    'all_links'?: AllLinksProperty;
    /**
     * 
     * @type {AllDomainLinksProperty}
     * @memberof DtoResponsesMoreLikeThisResponseArticleResult
     */
    'all_domain_links'?: AllDomainLinksProperty;
    /**
     * 
     * @type {object}
     * @memberof DtoResponsesMoreLikeThisResponseArticleResult
     */
    'nlp'?: object;
    /**
     * 
     * @type {string}
     * @memberof DtoResponsesMoreLikeThisResponseArticleResult
     */
    'id': string;
    /**
     * 
     * @type {number}
     * @memberof DtoResponsesMoreLikeThisResponseArticleResult
     */
    'score': number;
    /**
     * 
     * @type {Array<SimilarDocument>}
     * @memberof DtoResponsesMoreLikeThisResponseArticleResult
     */
    'similar_documents'?: Array<SimilarDocument>;
}

