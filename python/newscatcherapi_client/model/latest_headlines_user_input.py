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


class LatestHeadlinesUserInput(
    schemas.DictSchema
):
    """NOTE: This class is auto generated by Konfig.
    Ref: https://konfigthis.com

    Do not edit the class manually.
    """


    class MetaOapg:
        
        class properties:
        
            @staticmethod
            def lang() -> typing.Type['ModelList']:
                return ModelList
        
            @staticmethod
            def not_lang() -> typing.Type['ModelList']:
                return ModelList
        
            @staticmethod
            def countries() -> typing.Type['ModelList']:
                return ModelList
        
            @staticmethod
            def not_countries() -> typing.Type['ModelList']:
                return ModelList
            page = schemas.IntSchema
            size = schemas.IntSchema
        
            @staticmethod
            def sources() -> typing.Type['ModelList']:
                return ModelList
        
            @staticmethod
            def not_sources() -> typing.Type['ModelList']:
                return ModelList
            
            
            class topic(
                schemas.StrBase,
                schemas.NoneBase,
                schemas.Schema,
                schemas.NoneStrMixin
            ):
            
            
                def __new__(
                    cls,
                    *args: typing.Union[None, str, ],
                    _configuration: typing.Optional[schemas.Configuration] = None,
                ) -> 'topic':
                    return super().__new__(
                        cls,
                        *args,
                        _configuration=_configuration,
                    )
            __annotations__ = {
                "lang": lang,
                "not_lang": not_lang,
                "countries": countries,
                "not_countries": not_countries,
                "page": page,
                "size": size,
                "sources": sources,
                "not_sources": not_sources,
                "topic": topic,
            }
    
    @typing.overload
    def __getitem__(self, name: typing_extensions.Literal["lang"]) -> 'ModelList': ...
    
    @typing.overload
    def __getitem__(self, name: typing_extensions.Literal["not_lang"]) -> 'ModelList': ...
    
    @typing.overload
    def __getitem__(self, name: typing_extensions.Literal["countries"]) -> 'ModelList': ...
    
    @typing.overload
    def __getitem__(self, name: typing_extensions.Literal["not_countries"]) -> 'ModelList': ...
    
    @typing.overload
    def __getitem__(self, name: typing_extensions.Literal["page"]) -> MetaOapg.properties.page: ...
    
    @typing.overload
    def __getitem__(self, name: typing_extensions.Literal["size"]) -> MetaOapg.properties.size: ...
    
    @typing.overload
    def __getitem__(self, name: typing_extensions.Literal["sources"]) -> 'ModelList': ...
    
    @typing.overload
    def __getitem__(self, name: typing_extensions.Literal["not_sources"]) -> 'ModelList': ...
    
    @typing.overload
    def __getitem__(self, name: typing_extensions.Literal["topic"]) -> MetaOapg.properties.topic: ...
    
    @typing.overload
    def __getitem__(self, name: str) -> schemas.UnsetAnyTypeSchema: ...
    
    def __getitem__(self, name: typing.Union[typing_extensions.Literal["lang", "not_lang", "countries", "not_countries", "page", "size", "sources", "not_sources", "topic", ], str]):
        # dict_instance[name] accessor
        return super().__getitem__(name)
    
    
    @typing.overload
    def get_item_oapg(self, name: typing_extensions.Literal["lang"]) -> typing.Union['ModelList', schemas.Unset]: ...
    
    @typing.overload
    def get_item_oapg(self, name: typing_extensions.Literal["not_lang"]) -> typing.Union['ModelList', schemas.Unset]: ...
    
    @typing.overload
    def get_item_oapg(self, name: typing_extensions.Literal["countries"]) -> typing.Union['ModelList', schemas.Unset]: ...
    
    @typing.overload
    def get_item_oapg(self, name: typing_extensions.Literal["not_countries"]) -> typing.Union['ModelList', schemas.Unset]: ...
    
    @typing.overload
    def get_item_oapg(self, name: typing_extensions.Literal["page"]) -> typing.Union[MetaOapg.properties.page, schemas.Unset]: ...
    
    @typing.overload
    def get_item_oapg(self, name: typing_extensions.Literal["size"]) -> typing.Union[MetaOapg.properties.size, schemas.Unset]: ...
    
    @typing.overload
    def get_item_oapg(self, name: typing_extensions.Literal["sources"]) -> typing.Union['ModelList', schemas.Unset]: ...
    
    @typing.overload
    def get_item_oapg(self, name: typing_extensions.Literal["not_sources"]) -> typing.Union['ModelList', schemas.Unset]: ...
    
    @typing.overload
    def get_item_oapg(self, name: typing_extensions.Literal["topic"]) -> typing.Union[MetaOapg.properties.topic, schemas.Unset]: ...
    
    @typing.overload
    def get_item_oapg(self, name: str) -> typing.Union[schemas.UnsetAnyTypeSchema, schemas.Unset]: ...
    
    def get_item_oapg(self, name: typing.Union[typing_extensions.Literal["lang", "not_lang", "countries", "not_countries", "page", "size", "sources", "not_sources", "topic", ], str]):
        return super().get_item_oapg(name)
    

    def __new__(
        cls,
        *args: typing.Union[dict, frozendict.frozendict, ],
        lang: typing.Union['ModelList', schemas.Unset] = schemas.unset,
        not_lang: typing.Union['ModelList', schemas.Unset] = schemas.unset,
        countries: typing.Union['ModelList', schemas.Unset] = schemas.unset,
        not_countries: typing.Union['ModelList', schemas.Unset] = schemas.unset,
        page: typing.Union[MetaOapg.properties.page, decimal.Decimal, int, schemas.Unset] = schemas.unset,
        size: typing.Union[MetaOapg.properties.size, decimal.Decimal, int, schemas.Unset] = schemas.unset,
        sources: typing.Union['ModelList', schemas.Unset] = schemas.unset,
        not_sources: typing.Union['ModelList', schemas.Unset] = schemas.unset,
        topic: typing.Union[MetaOapg.properties.topic, None, str, schemas.Unset] = schemas.unset,
        _configuration: typing.Optional[schemas.Configuration] = None,
        **kwargs: typing.Union[schemas.AnyTypeSchema, dict, frozendict.frozendict, str, date, datetime, uuid.UUID, int, float, decimal.Decimal, None, list, tuple, bytes],
    ) -> 'LatestHeadlinesUserInput':
        return super().__new__(
            cls,
            *args,
            lang=lang,
            not_lang=not_lang,
            countries=countries,
            not_countries=not_countries,
            page=page,
            size=size,
            sources=sources,
            not_sources=not_sources,
            topic=topic,
            _configuration=_configuration,
            **kwargs,
        )

from newscatcherapi_client.model.model_list import ModelList
