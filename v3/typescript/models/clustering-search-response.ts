/*
NewsCatcher-V3 Production API

<img src='https://uploads-ssl.webflow.com/6429857b17973b636c2195c5/646c6f1eb774ff2f2997bec5_newscatcher_.svg' width='286' height='35' /> <br>  <br>Visit our website  <a href='https://newscatcherapi.com'>https://newscatcherapi.com</a> <br> <p style=\"color: red\"><b><em> This is a Testing Phase API. Please use it for testing purposes only. </em></b></p> <br>

The version of the OpenAPI document: Beta-3.0.0
Contact: maksym@newscatcherapi.com

NOTE: This file is auto generated by Konfig (https://konfigthis.com).
*/
import type * as buffer from "buffer"

import { Cluster } from './cluster';

/**
 * 
 * @export
 * @interface ClusteringSearchResponse
 */
export interface ClusteringSearchResponse {
    /**
     * 
     * @type {string}
     * @memberof ClusteringSearchResponse
     */
    'status'?: string;
    /**
     * 
     * @type {number}
     * @memberof ClusteringSearchResponse
     */
    'total_hits': number;
    /**
     * 
     * @type {number}
     * @memberof ClusteringSearchResponse
     */
    'page': number;
    /**
     * 
     * @type {number}
     * @memberof ClusteringSearchResponse
     */
    'total_pages': number;
    /**
     * 
     * @type {number}
     * @memberof ClusteringSearchResponse
     */
    'page_size': number;
    /**
     * 
     * @type {number}
     * @memberof ClusteringSearchResponse
     */
    'clusters_count': number;
    /**
     * 
     * @type {Array<Cluster>}
     * @memberof ClusteringSearchResponse
     */
    'clusters': Array<Cluster>;
    /**
     * 
     * @type {object}
     * @memberof ClusteringSearchResponse
     */
    'user_input': object;
}

