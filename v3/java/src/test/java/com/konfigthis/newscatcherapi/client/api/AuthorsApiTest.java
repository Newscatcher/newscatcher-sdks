/*
 * NewsCatcher-V3 Production API
 * <img src='https://uploads-ssl.webflow.com/6429857b17973b636c2195c5/646c6f1eb774ff2f2997bec5_newscatcher_.svg' width='286' height='35' /> <br>  <br>Visit our website  <a href='https://newscatcherapi.com'>https://newscatcherapi.com</a>
 *
 * The version of the OpenAPI document: Beta-3.0.0
 * Contact: maksym@newscatcherapi.com
 *
 * NOTE: This class is auto generated by Konfig (https://konfigthis.com).
 * Do not edit the class manually.
 */


package com.konfigthis.newscatcherapi.client.api;

import com.konfigthis.newscatcherapi.client.ApiException;
import com.konfigthis.newscatcherapi.client.ApiClient;
import com.konfigthis.newscatcherapi.client.ApiException;
import com.konfigthis.newscatcherapi.client.Configuration;
import com.konfigthis.newscatcherapi.client.model.AuthorSearchRequest;
import org.junit.jupiter.api.Disabled;
import org.junit.jupiter.api.Test;
import org.junit.jupiter.api.BeforeAll;

import java.util.ArrayList;
import java.util.HashMap;
import java.util.List;
import java.util.Map;

/**
 * API tests for AuthorsApi
 */
@Disabled
public class AuthorsApiTest {

    private static AuthorsApi api;

    
    @BeforeAll
    public static void beforeClass() {
        ApiClient apiClient = Configuration.getDefaultApiClient();
        api = new AuthorsApi(apiClient);
    }

    /**
     * [Get] Search By Author Request
     *
     * This endpoint allows you to search for articles by author. You need to specify the author name. You can also filter by language, country, source, and more.
     *
     * @throws ApiException if the Api call fails
     */
    @Test
    public void getTest() throws ApiException {
        String authorName = null;
        String sources = null;
        String predefinedSources = null;
        String notSources = null;
        String lang = null;
        String notLang = null;
        String countries = null;
        String notCountries = null;
        String from = null;
        String to = null;
        String publishedDatePrecision = null;
        Boolean byParseDate = null;
        String sortBy = null;
        String rankedOnly = null;
        Integer fromRank = null;
        Integer toRank = null;
        Boolean isHeadline = null;
        Boolean isPaidContent = null;
        String parentUrl = null;
        String allLinks = null;
        String allDomainLinks = null;
        Integer wordCountMin = null;
        Integer wordCountMax = null;
        Integer page = null;
        Integer pageSize = null;
        Boolean includeNlpData = null;
        Boolean hasNlp = null;
        String theme = null;
        String nerName = null;
        Double titleSentimentMin = null;
        Double titleSentimentMax = null;
        Double contentSentimentMin = null;
        Double contentSentimentMax = null;
        Object response = api.get(authorName)
                .sources(sources)
                .predefinedSources(predefinedSources)
                .notSources(notSources)
                .lang(lang)
                .notLang(notLang)
                .countries(countries)
                .notCountries(notCountries)
                .from(from)
                .to(to)
                .publishedDatePrecision(publishedDatePrecision)
                .byParseDate(byParseDate)
                .sortBy(sortBy)
                .rankedOnly(rankedOnly)
                .fromRank(fromRank)
                .toRank(toRank)
                .isHeadline(isHeadline)
                .isPaidContent(isPaidContent)
                .parentUrl(parentUrl)
                .allLinks(allLinks)
                .allDomainLinks(allDomainLinks)
                .wordCountMin(wordCountMin)
                .wordCountMax(wordCountMax)
                .page(page)
                .pageSize(pageSize)
                .includeNlpData(includeNlpData)
                .hasNlp(hasNlp)
                .theme(theme)
                .nerName(nerName)
                .titleSentimentMin(titleSentimentMin)
                .titleSentimentMax(titleSentimentMax)
                .contentSentimentMin(contentSentimentMin)
                .contentSentimentMax(contentSentimentMax)
                .execute();
        // TODO: test validations
    }

    /**
     * [Post] Search By Author Request
     *
     * This endpoint allows you to search for articles by author. You need to specify the author name. You can also filter by language, country, source, and more.
     *
     * @throws ApiException if the Api call fails
     */
    @Test
    public void postTest() throws ApiException {
        String authorName = null;
        String sources = null;
        String predefinedSources = null;
        String notSources = null;
        String lang = null;
        String notLang = null;
        String countries = null;
        String notCountries = null;
        String from = null;
        String to = null;
        String publishedDatePrecision = null;
        Boolean byParseDate = null;
        String sortBy = null;
        String rankedOnly = null;
        Integer fromRank = null;
        Integer toRank = null;
        Boolean isHeadline = null;
        Boolean isPaidContent = null;
        String parentUrl = null;
        String allLinks = null;
        String allDomainLinks = null;
        Integer wordCountMin = null;
        Integer wordCountMax = null;
        Integer page = null;
        Integer pageSize = null;
        Boolean includeNlpData = null;
        Boolean hasNlp = null;
        String theme = null;
        String nerName = null;
        Double titleSentimentMin = null;
        Double titleSentimentMax = null;
        Double contentSentimentMin = null;
        Double contentSentimentMax = null;
        Object response = api.post(authorName)
                .sources(sources)
                .predefinedSources(predefinedSources)
                .notSources(notSources)
                .lang(lang)
                .notLang(notLang)
                .countries(countries)
                .notCountries(notCountries)
                .from(from)
                .to(to)
                .publishedDatePrecision(publishedDatePrecision)
                .byParseDate(byParseDate)
                .sortBy(sortBy)
                .rankedOnly(rankedOnly)
                .fromRank(fromRank)
                .toRank(toRank)
                .isHeadline(isHeadline)
                .isPaidContent(isPaidContent)
                .parentUrl(parentUrl)
                .allLinks(allLinks)
                .allDomainLinks(allDomainLinks)
                .wordCountMin(wordCountMin)
                .wordCountMax(wordCountMax)
                .page(page)
                .pageSize(pageSize)
                .includeNlpData(includeNlpData)
                .hasNlp(hasNlp)
                .theme(theme)
                .nerName(nerName)
                .titleSentimentMin(titleSentimentMin)
                .titleSentimentMax(titleSentimentMax)
                .contentSentimentMin(contentSentimentMin)
                .contentSentimentMax(contentSentimentMax)
                .execute();
        // TODO: test validations
    }

}
