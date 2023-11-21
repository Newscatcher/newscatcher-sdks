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
from pydantic import BaseModel, Field, RootModel

from newscatcherapi_client.pydantic.dto_responses_author_search_response_failed_search_response import DtoResponsesAuthorSearchResponseFailedSearchResponse
from newscatcherapi_client.pydantic.dto_responses_author_search_response_search_response import DtoResponsesAuthorSearchResponseSearchResponse

AuthorsGetResponse = typing.Union[DtoResponsesAuthorSearchResponseSearchResponse,DtoResponsesAuthorSearchResponseFailedSearchResponse]
