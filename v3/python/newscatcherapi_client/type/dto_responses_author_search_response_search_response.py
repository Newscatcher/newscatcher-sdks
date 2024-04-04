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

from newscatcherapi_client.type.dto_responses_author_search_response_search_response_articles import DtoResponsesAuthorSearchResponseSearchResponseArticles

class RequiredDtoResponsesAuthorSearchResponseSearchResponse(TypedDict):
    total_hits: int

    page: int

    total_pages: int

    page_size: int

    articles: DtoResponsesAuthorSearchResponseSearchResponseArticles

    user_input: typing.Dict[str, typing.Union[bool, date, datetime, dict, float, int, list, str, None]]

class OptionalDtoResponsesAuthorSearchResponseSearchResponse(TypedDict, total=False):
    status: str

class DtoResponsesAuthorSearchResponseSearchResponse(RequiredDtoResponsesAuthorSearchResponseSearchResponse, OptionalDtoResponsesAuthorSearchResponseSearchResponse):
    pass
