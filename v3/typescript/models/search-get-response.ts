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
import { Cluster } from './cluster';
import { ClusteringSearchResponse } from './clustering-search-response';
import { DtoResponsesSearchResponseArticleResult } from './dto-responses-search-response-article-result';
import { DtoResponsesSearchResponseFailedSearchResponse } from './dto-responses-search-response-failed-search-response';
import { DtoResponsesSearchResponseSearchResponse } from './dto-responses-search-response-search-response';
import { JournalistsProperty } from './journalists-property';

/**
 * @type SearchGetResponse
 * @export
 */
export type SearchGetResponse = DtoResponsesSearchResponseSearchResponse | DtoResponsesSearchResponseFailedSearchResponse | ClusteringSearchResponse;


