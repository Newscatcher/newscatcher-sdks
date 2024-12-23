# coding: utf-8

"""
    NewsCatcher-V3 Production API

    <img src='https://uploads-ssl.webflow.com/6429857b17973b636c2195c5/646c6f1eb774ff2f2997bec5_newscatcher_.svg' width='286' height='35' /> <br>  <br>Visit our website  <a href='https://newscatcherapi.com'>https://newscatcherapi.com</a>

    The version of the OpenAPI document: 3.2.16
    Contact: maksym@newscatcherapi.com
    Generated by: https://konfigthis.com
"""

from datetime import datetime, date
import typing
from enum import Enum
from typing_extensions import TypedDict, Literal, TYPE_CHECKING
from pydantic import BaseModel, Field, RootModel, ConfigDict


class SearchRequest(BaseModel):
    q: str = Field(alias='q')

    search_in: typing.Optional[str] = Field(None, alias='search_in')

    predefined_sources: typing.Optional[typing.Union[bool, date, datetime, dict, float, int, list, str, None]] = Field(None, alias='predefined_sources')

    sources: typing.Optional[typing.Union[bool, date, datetime, dict, float, int, list, str, None]] = Field(None, alias='sources')

    not_sources: typing.Optional[typing.Union[bool, date, datetime, dict, float, int, list, str, None]] = Field(None, alias='not_sources')

    lang: typing.Optional[typing.Union[bool, date, datetime, dict, float, int, list, str, None]] = Field(None, alias='lang')

    not_lang: typing.Optional[typing.Union[bool, date, datetime, dict, float, int, list, str, None]] = Field(None, alias='not_lang')

    countries: typing.Optional[typing.Union[bool, date, datetime, dict, float, int, list, str, None]] = Field(None, alias='countries')

    not_countries: typing.Optional[typing.Union[bool, date, datetime, dict, float, int, list, str, None]] = Field(None, alias='not_countries')

    not_author_name: typing.Optional[typing.Union[bool, date, datetime, dict, float, int, list, str, None]] = Field(None, alias='not_author_name')

    from_: typing.Optional[typing.Union[str, datetime]] = Field(None, alias='from_')

    to_: typing.Optional[typing.Union[str, datetime]] = Field(None, alias='to_')

    published_date_precision: typing.Optional[str] = Field(None, alias='published_date_precision')

    by_parse_date: typing.Optional[typing.Union[str, bool]] = Field(None, alias='by_parse_date')

    sort_by: typing.Optional[str] = Field(None, alias='sort_by')

    ranked_only: typing.Optional[typing.Union[str, bool]] = Field(None, alias='ranked_only')

    from_rank: typing.Optional[typing.Union[str, int]] = Field(None, alias='from_rank')

    to_rank: typing.Optional[typing.Union[str, int]] = Field(None, alias='to_rank')

    is_headline: typing.Optional[typing.Union[str, bool]] = Field(None, alias='is_headline')

    is_opinion: typing.Optional[typing.Union[str, bool]] = Field(None, alias='is_opinion')

    is_paid_content: typing.Optional[typing.Union[str, bool]] = Field(None, alias='is_paid_content')

    parent_url: typing.Optional[typing.Union[bool, date, datetime, dict, float, int, list, str, None]] = Field(None, alias='parent_url')

    all_links: typing.Optional[typing.Union[bool, date, datetime, dict, float, int, list, str, None]] = Field(None, alias='all_links')

    all_domain_links: typing.Optional[typing.Union[bool, date, datetime, dict, float, int, list, str, None]] = Field(None, alias='all_domain_links')

    word_count_min: typing.Optional[typing.Union[str, int]] = Field(None, alias='word_count_min')

    word_count_max: typing.Optional[typing.Union[str, int]] = Field(None, alias='word_count_max')

    page: typing.Optional[typing.Union[str, int]] = Field(None, alias='page')

    page_size: typing.Optional[typing.Union[str, int]] = Field(None, alias='page_size')

    clustering_variable: typing.Optional[str] = Field(None, alias='clustering_variable')

    clustering_enabled: typing.Optional[typing.Union[str, bool]] = Field(None, alias='clustering_enabled')

    clustering_threshold: typing.Optional[typing.Union[typing.Union[int, float], str]] = Field(None, alias='clustering_threshold')

    include_nlp_data: typing.Optional[typing.Union[str, bool]] = Field(None, alias='include_nlp_data')

    has_nlp: typing.Optional[bool] = Field(None, alias='has_nlp')

    theme: typing.Optional[str] = Field(None, alias='theme')

    not_theme: typing.Optional[str] = Field(None, alias='not_theme')

    o_r_g_entity_name: typing.Optional[str] = Field(None, alias='ORG_entity_name')

    p_e_r_entity_name: typing.Optional[str] = Field(None, alias='PER_entity_name')

    l_o_c_entity_name: typing.Optional[str] = Field(None, alias='LOC_entity_name')

    m_i_s_c_entity_name: typing.Optional[str] = Field(None, alias='MISC_entity_name')

    title_sentiment_min: typing.Optional[typing.Union[int, float]] = Field(None, alias='title_sentiment_min')

    title_sentiment_max: typing.Optional[typing.Union[int, float]] = Field(None, alias='title_sentiment_max')

    content_sentiment_min: typing.Optional[typing.Union[int, float]] = Field(None, alias='content_sentiment_min')

    content_sentiment_max: typing.Optional[typing.Union[int, float]] = Field(None, alias='content_sentiment_max')

    iptc_tags: typing.Optional[typing.Union[bool, date, datetime, dict, float, int, list, str, None]] = Field(None, alias='iptc_tags')

    not_iptc_tags: typing.Optional[typing.Union[bool, date, datetime, dict, float, int, list, str, None]] = Field(None, alias='not_iptc_tags')

    source_name: typing.Optional[typing.Union[bool, date, datetime, dict, float, int, list, str, None]] = Field(None, alias='source_name')

    iab_tags: typing.Optional[typing.Union[bool, date, datetime, dict, float, int, list, str, None]] = Field(None, alias='iab_tags')

    not_iab_tags: typing.Optional[typing.Union[bool, date, datetime, dict, float, int, list, str, None]] = Field(None, alias='not_iab_tags')

    exclude_duplicates: typing.Optional[bool] = Field(None, alias='exclude_duplicates')

    additional_domain_info: typing.Optional[bool] = Field(None, alias='additional_domain_info')

    is_news_domain: typing.Optional[bool] = Field(None, alias='is_news_domain')

    news_domain_type: typing.Optional[typing.Union[bool, date, datetime, dict, float, int, list, str, None]] = Field(None, alias='news_domain_type')

    news_type: typing.Optional[typing.Union[bool, date, datetime, dict, float, int, list, str, None]] = Field(None, alias='news_type')

    model_config = ConfigDict(
        protected_namespaces=(),
        arbitrary_types_allowed=True
    )
