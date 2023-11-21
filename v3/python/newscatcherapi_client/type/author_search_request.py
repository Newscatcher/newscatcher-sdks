# coding: utf-8

"""
    NewsCatcher-V3 Production API

    <img src='https://uploads-ssl.webflow.com/6429857b17973b636c2195c5/646c6f1eb774ff2f2997bec5_newscatcher_.svg' width='286' height='35' /> <br>  <br>Visit our website  <a href='https://newscatcherapi.com'>https://newscatcherapi.com</a>

    The version of the OpenAPI document: Beta-3.0.0
    Contact: maksym@newscatcherapi.com
    Generated by: https://konfigthis.com
"""

from datetime import datetime, date
import typing
from enum import Enum
from typing_extensions import TypedDict, Literal, TYPE_CHECKING


class RequiredAuthorSearchRequest(TypedDict):
    author_name: str

class OptionalAuthorSearchRequest(TypedDict, total=False):
    sources: str

    predefined_sources: str

    not_sources: str

    lang: str

    not_lang: str

    countries: str

    not_countries: str

    from_: typing.Union[str, datetime]

    to_: typing.Union[str, datetime]

    published_date_precision: str

    by_parse_date: bool

    sort_by: str

    ranked_only: str

    from_rank: int

    to_rank: int

    is_headline: bool

    is_paid_content: bool

    parent_url: str

    all_links: str

    all_domain_links: str

    word_count_min: int

    word_count_max: int

    page: int

    page_size: int

    include_nlp_data: bool

    has_nlp: bool

    theme: str

    ner_name: str

    title_sentiment_min: typing.Union[int, float]

    title_sentiment_max: typing.Union[int, float]

    content_sentiment_min: typing.Union[int, float]

    content_sentiment_max: typing.Union[int, float]

class AuthorSearchRequest(RequiredAuthorSearchRequest, OptionalAuthorSearchRequest):
    pass
