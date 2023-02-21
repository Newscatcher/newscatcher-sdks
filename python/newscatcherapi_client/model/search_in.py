# coding: utf-8

"""
    NewsCatcher News API V2

    NewsCatcher is a data-as-a-service startup that has one main goal: to build the largest database of structured news articles published online. In other words, we're like Google for the news part of the web, which you can access as a source of data.  Some useful links: - [How NewsCatcher Works](https://docs.newscatcherapi.com/knowledge-base/how-newscatcher-works) - [GitHub for the Python SDK](https://github.com/NewscatcherAPI/newscatcherapi-sdk-python)   # noqa: E501

    The version of the OpenAPI document: 1.0.1
    Contact: team@newscatcherapi.com
    Generated by: https://konfigthis.com
"""

from datetime import date, datetime  # noqa: F401
import decimal  # noqa: F401
import functools  # noqa: F401
import io  # noqa: F401
import re  # noqa: F401
import typing  # noqa: F401
import typing_extensions  # noqa: F401
import uuid  # noqa: F401

import frozendict  # noqa: F401

from newscatcherapi_client import schemas  # noqa: F401


class SearchIn(
    schemas.EnumBase,
    schemas.StrSchema
):
    """NOTE: This class is auto generated by Konfig.
    Ref: https://konfigthis.com

    Do not edit the class manually.
    """


    class MetaOapg:
        enum_value_to_name = {
            "title": "TITLE",
            "summary": "SUMMARY",
            "title_summary": "TITLE_SUMMARY",
        }
    
    @schemas.classproperty
    def TITLE(cls):
        return cls("title")
    
    @schemas.classproperty
    def SUMMARY(cls):
        return cls("summary")
    
    @schemas.classproperty
    def TITLE_SUMMARY(cls):
        return cls("title_summary")
