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

from newscatcherapi_client.pydantic.dto_responses_more_like_this_response_search_response_articles import DtoResponsesMoreLikeThisResponseSearchResponseArticles

class DtoResponsesMoreLikeThisResponseSearchResponse(BaseModel):
    total_hits: int = Field(alias='total_hits')

    page: int = Field(alias='page')

    total_pages: int = Field(alias='total_pages')

    page_size: int = Field(alias='page_size')

    articles: DtoResponsesMoreLikeThisResponseSearchResponseArticles = Field(alias='articles')

    user_input: typing.Dict[str, typing.Union[bool, date, datetime, dict, float, int, list, str, None]] = Field(alias='user_input')

    status: typing.Optional[str] = Field(None, alias='status')

    model_config = ConfigDict(
        protected_namespaces=(),
        arbitrary_types_allowed=True
    )
