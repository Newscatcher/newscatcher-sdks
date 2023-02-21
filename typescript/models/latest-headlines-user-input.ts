/* tslint:disable */
/* eslint-disable */
/**
 * NewsCatcher News API V2
 * NewsCatcher is a data-as-a-service startup that has one main goal: to build the largest database of structured news articles published online. In other words, we\'re like Google for the news part of the web, which you can access as a source of data.  Some useful links: - [How NewsCatcher Works](https://docs.newscatcherapi.com/knowledge-base/how-newscatcher-works) - [GitHub for the Python SDK](https://github.com/NewscatcherAPI/newscatcherapi-sdk-python) 
 *
 * The version of the OpenAPI document: 1.0.1
 * Contact: team@newscatcherapi.com
 *
 * NOTE: This file is auto generated by Konfig (https://konfigthis.com).
 * https://konfigthis.com
 * Do not edit the class manually.
 */


/**
 * 
 * @export
 * @interface LatestHeadlinesUserInput
 */
export interface LatestHeadlinesUserInput {
    /**
     * 
     * @type {Array<string>}
     * @memberof LatestHeadlinesUserInput
     */
    'lang'?: Array<string> | null;
    /**
     * 
     * @type {Array<string>}
     * @memberof LatestHeadlinesUserInput
     */
    'not_lang'?: Array<string> | null;
    /**
     * 
     * @type {Array<string>}
     * @memberof LatestHeadlinesUserInput
     */
    'countries'?: Array<string> | null;
    /**
     * 
     * @type {Array<string>}
     * @memberof LatestHeadlinesUserInput
     */
    'not_countries'?: Array<string> | null;
    /**
     * 
     * @type {number}
     * @memberof LatestHeadlinesUserInput
     */
    'page'?: number;
    /**
     * 
     * @type {number}
     * @memberof LatestHeadlinesUserInput
     */
    'size'?: number;
    /**
     * 
     * @type {Array<string>}
     * @memberof LatestHeadlinesUserInput
     */
    'sources'?: Array<string> | null;
    /**
     * 
     * @type {Array<string>}
     * @memberof LatestHeadlinesUserInput
     */
    'not_sources'?: Array<string> | null;
    /**
     * 
     * @type {string}
     * @memberof LatestHeadlinesUserInput
     */
    'topic'?: string | null;
}
