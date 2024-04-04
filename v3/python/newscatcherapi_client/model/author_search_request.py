# coding: utf-8

"""
    NewsCatcher-V3 Production API

    <img src='https://uploads-ssl.webflow.com/6429857b17973b636c2195c5/646c6f1eb774ff2f2997bec5_newscatcher_.svg' width='286' height='35' /> <br>  <br>Visit our website  <a href='https://newscatcherapi.com'>https://newscatcherapi.com</a>

    The version of the OpenAPI document: 3.2.16
    Contact: maksym@newscatcherapi.com
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


class AuthorSearchRequest(
    schemas.DictSchema
):
    """
    This class is auto generated by Konfig (https://konfigthis.com)
    """


    class MetaOapg:
        required = {
            "author_name",
        }
        
        class properties:
            author_name = schemas.StrSchema
            not_author_name = schemas.StrSchema
            sources = schemas.AnyTypeSchema
            predefined_sources = schemas.AnyTypeSchema
            not_sources = schemas.AnyTypeSchema
            lang = schemas.AnyTypeSchema
            not_lang = schemas.AnyTypeSchema
            countries = schemas.AnyTypeSchema
            not_countries = schemas.AnyTypeSchema
            
            
            class from_(
                schemas.ComposedSchema,
            ):
            
            
                class MetaOapg:
                    items = schemas.StrSchema
                    any_of_1 = schemas.DateTimeSchema
                    
                    @classmethod
                    @functools.lru_cache()
                    def any_of(cls):
                        # we need this here to make our import statements work
                        # we must store _composed_schemas in here so the code is only run
                        # when we invoke this method. If we kept this at the class
                        # level we would get an error because the class level
                        # code would be run when this module is imported, and these composed
                        # classes don't exist yet because their module has not finished
                        # loading
                        return [
                            cls.items,
                            cls.any_of_1,
                        ]
            
            
                def __new__(
                    cls,
                    *args: typing.Union[dict, frozendict.frozendict, str, date, datetime, uuid.UUID, int, float, decimal.Decimal, bool, None, list, tuple, bytes, io.FileIO, io.BufferedReader, ],
                    _configuration: typing.Optional[schemas.Configuration] = None,
                    **kwargs: typing.Union[schemas.AnyTypeSchema, dict, frozendict.frozendict, str, date, datetime, uuid.UUID, int, float, decimal.Decimal, None, list, tuple, bytes],
                ) -> 'from_':
                    return super().__new__(
                        cls,
                        *args,
                        _configuration=_configuration,
                        **kwargs,
                    )
            
            
            class to_(
                schemas.ComposedSchema,
            ):
            
            
                class MetaOapg:
                    items = schemas.StrSchema
                    any_of_1 = schemas.DateTimeSchema
                    
                    @classmethod
                    @functools.lru_cache()
                    def any_of(cls):
                        # we need this here to make our import statements work
                        # we must store _composed_schemas in here so the code is only run
                        # when we invoke this method. If we kept this at the class
                        # level we would get an error because the class level
                        # code would be run when this module is imported, and these composed
                        # classes don't exist yet because their module has not finished
                        # loading
                        return [
                            cls.items,
                            cls.any_of_1,
                        ]
            
            
                def __new__(
                    cls,
                    *args: typing.Union[dict, frozendict.frozendict, str, date, datetime, uuid.UUID, int, float, decimal.Decimal, bool, None, list, tuple, bytes, io.FileIO, io.BufferedReader, ],
                    _configuration: typing.Optional[schemas.Configuration] = None,
                    **kwargs: typing.Union[schemas.AnyTypeSchema, dict, frozendict.frozendict, str, date, datetime, uuid.UUID, int, float, decimal.Decimal, None, list, tuple, bytes],
                ) -> 'to_':
                    return super().__new__(
                        cls,
                        *args,
                        _configuration=_configuration,
                        **kwargs,
                    )
            published_date_precision = schemas.StrSchema
            by_parse_date = schemas.BoolSchema
            sort_by = schemas.StrSchema
            ranked_only = schemas.StrSchema
            from_rank = schemas.IntSchema
            to_rank = schemas.IntSchema
            is_headline = schemas.BoolSchema
            is_paid_content = schemas.BoolSchema
            parent_url = schemas.AnyTypeSchema
            all_links = schemas.AnyTypeSchema
            all_domain_links = schemas.AnyTypeSchema
            
            
            class word_count_min(
                schemas.IntSchema
            ):
            
            
                class MetaOapg:
                    inclusive_minimum = 0
            
            
            class word_count_max(
                schemas.IntSchema
            ):
            
            
                class MetaOapg:
                    inclusive_minimum = 0
            
            
            class page(
                schemas.IntSchema
            ):
            
            
                class MetaOapg:
                    inclusive_minimum = 0
            
            
            class page_size(
                schemas.IntSchema
            ):
            
            
                class MetaOapg:
                    inclusive_minimum = 0
            include_nlp_data = schemas.BoolSchema
            has_nlp = schemas.BoolSchema
            theme = schemas.StrSchema
            not_theme = schemas.StrSchema
            ner_name = schemas.StrSchema
            title_sentiment_min = schemas.NumberSchema
            title_sentiment_max = schemas.NumberSchema
            content_sentiment_min = schemas.NumberSchema
            content_sentiment_max = schemas.NumberSchema
            iptc_tags = schemas.AnyTypeSchema
            not_iptc_tags = schemas.AnyTypeSchema
            __annotations__ = {
                "author_name": author_name,
                "not_author_name": not_author_name,
                "sources": sources,
                "predefined_sources": predefined_sources,
                "not_sources": not_sources,
                "lang": lang,
                "not_lang": not_lang,
                "countries": countries,
                "not_countries": not_countries,
                "from_": from_,
                "to_": to_,
                "published_date_precision": published_date_precision,
                "by_parse_date": by_parse_date,
                "sort_by": sort_by,
                "ranked_only": ranked_only,
                "from_rank": from_rank,
                "to_rank": to_rank,
                "is_headline": is_headline,
                "is_paid_content": is_paid_content,
                "parent_url": parent_url,
                "all_links": all_links,
                "all_domain_links": all_domain_links,
                "word_count_min": word_count_min,
                "word_count_max": word_count_max,
                "page": page,
                "page_size": page_size,
                "include_nlp_data": include_nlp_data,
                "has_nlp": has_nlp,
                "theme": theme,
                "not_theme": not_theme,
                "ner_name": ner_name,
                "title_sentiment_min": title_sentiment_min,
                "title_sentiment_max": title_sentiment_max,
                "content_sentiment_min": content_sentiment_min,
                "content_sentiment_max": content_sentiment_max,
                "iptc_tags": iptc_tags,
                "not_iptc_tags": not_iptc_tags,
            }
    
    author_name: MetaOapg.properties.author_name
    
    @typing.overload
    def __getitem__(self, name: typing_extensions.Literal["author_name"]) -> MetaOapg.properties.author_name: ...
    
    @typing.overload
    def __getitem__(self, name: typing_extensions.Literal["not_author_name"]) -> MetaOapg.properties.not_author_name: ...
    
    @typing.overload
    def __getitem__(self, name: typing_extensions.Literal["sources"]) -> MetaOapg.properties.sources: ...
    
    @typing.overload
    def __getitem__(self, name: typing_extensions.Literal["predefined_sources"]) -> MetaOapg.properties.predefined_sources: ...
    
    @typing.overload
    def __getitem__(self, name: typing_extensions.Literal["not_sources"]) -> MetaOapg.properties.not_sources: ...
    
    @typing.overload
    def __getitem__(self, name: typing_extensions.Literal["lang"]) -> MetaOapg.properties.lang: ...
    
    @typing.overload
    def __getitem__(self, name: typing_extensions.Literal["not_lang"]) -> MetaOapg.properties.not_lang: ...
    
    @typing.overload
    def __getitem__(self, name: typing_extensions.Literal["countries"]) -> MetaOapg.properties.countries: ...
    
    @typing.overload
    def __getitem__(self, name: typing_extensions.Literal["not_countries"]) -> MetaOapg.properties.not_countries: ...
    
    @typing.overload
    def __getitem__(self, name: typing_extensions.Literal["from_"]) -> MetaOapg.properties.from_: ...
    
    @typing.overload
    def __getitem__(self, name: typing_extensions.Literal["to_"]) -> MetaOapg.properties.to_: ...
    
    @typing.overload
    def __getitem__(self, name: typing_extensions.Literal["published_date_precision"]) -> MetaOapg.properties.published_date_precision: ...
    
    @typing.overload
    def __getitem__(self, name: typing_extensions.Literal["by_parse_date"]) -> MetaOapg.properties.by_parse_date: ...
    
    @typing.overload
    def __getitem__(self, name: typing_extensions.Literal["sort_by"]) -> MetaOapg.properties.sort_by: ...
    
    @typing.overload
    def __getitem__(self, name: typing_extensions.Literal["ranked_only"]) -> MetaOapg.properties.ranked_only: ...
    
    @typing.overload
    def __getitem__(self, name: typing_extensions.Literal["from_rank"]) -> MetaOapg.properties.from_rank: ...
    
    @typing.overload
    def __getitem__(self, name: typing_extensions.Literal["to_rank"]) -> MetaOapg.properties.to_rank: ...
    
    @typing.overload
    def __getitem__(self, name: typing_extensions.Literal["is_headline"]) -> MetaOapg.properties.is_headline: ...
    
    @typing.overload
    def __getitem__(self, name: typing_extensions.Literal["is_paid_content"]) -> MetaOapg.properties.is_paid_content: ...
    
    @typing.overload
    def __getitem__(self, name: typing_extensions.Literal["parent_url"]) -> MetaOapg.properties.parent_url: ...
    
    @typing.overload
    def __getitem__(self, name: typing_extensions.Literal["all_links"]) -> MetaOapg.properties.all_links: ...
    
    @typing.overload
    def __getitem__(self, name: typing_extensions.Literal["all_domain_links"]) -> MetaOapg.properties.all_domain_links: ...
    
    @typing.overload
    def __getitem__(self, name: typing_extensions.Literal["word_count_min"]) -> MetaOapg.properties.word_count_min: ...
    
    @typing.overload
    def __getitem__(self, name: typing_extensions.Literal["word_count_max"]) -> MetaOapg.properties.word_count_max: ...
    
    @typing.overload
    def __getitem__(self, name: typing_extensions.Literal["page"]) -> MetaOapg.properties.page: ...
    
    @typing.overload
    def __getitem__(self, name: typing_extensions.Literal["page_size"]) -> MetaOapg.properties.page_size: ...
    
    @typing.overload
    def __getitem__(self, name: typing_extensions.Literal["include_nlp_data"]) -> MetaOapg.properties.include_nlp_data: ...
    
    @typing.overload
    def __getitem__(self, name: typing_extensions.Literal["has_nlp"]) -> MetaOapg.properties.has_nlp: ...
    
    @typing.overload
    def __getitem__(self, name: typing_extensions.Literal["theme"]) -> MetaOapg.properties.theme: ...
    
    @typing.overload
    def __getitem__(self, name: typing_extensions.Literal["not_theme"]) -> MetaOapg.properties.not_theme: ...
    
    @typing.overload
    def __getitem__(self, name: typing_extensions.Literal["ner_name"]) -> MetaOapg.properties.ner_name: ...
    
    @typing.overload
    def __getitem__(self, name: typing_extensions.Literal["title_sentiment_min"]) -> MetaOapg.properties.title_sentiment_min: ...
    
    @typing.overload
    def __getitem__(self, name: typing_extensions.Literal["title_sentiment_max"]) -> MetaOapg.properties.title_sentiment_max: ...
    
    @typing.overload
    def __getitem__(self, name: typing_extensions.Literal["content_sentiment_min"]) -> MetaOapg.properties.content_sentiment_min: ...
    
    @typing.overload
    def __getitem__(self, name: typing_extensions.Literal["content_sentiment_max"]) -> MetaOapg.properties.content_sentiment_max: ...
    
    @typing.overload
    def __getitem__(self, name: typing_extensions.Literal["iptc_tags"]) -> MetaOapg.properties.iptc_tags: ...
    
    @typing.overload
    def __getitem__(self, name: typing_extensions.Literal["not_iptc_tags"]) -> MetaOapg.properties.not_iptc_tags: ...
    
    @typing.overload
    def __getitem__(self, name: str) -> schemas.UnsetAnyTypeSchema: ...
    
    def __getitem__(self, name: typing.Union[typing_extensions.Literal["author_name", "not_author_name", "sources", "predefined_sources", "not_sources", "lang", "not_lang", "countries", "not_countries", "from_", "to_", "published_date_precision", "by_parse_date", "sort_by", "ranked_only", "from_rank", "to_rank", "is_headline", "is_paid_content", "parent_url", "all_links", "all_domain_links", "word_count_min", "word_count_max", "page", "page_size", "include_nlp_data", "has_nlp", "theme", "not_theme", "ner_name", "title_sentiment_min", "title_sentiment_max", "content_sentiment_min", "content_sentiment_max", "iptc_tags", "not_iptc_tags", ], str]):
        # dict_instance[name] accessor
        return super().__getitem__(name)
    
    
    @typing.overload
    def get_item_oapg(self, name: typing_extensions.Literal["author_name"]) -> MetaOapg.properties.author_name: ...
    
    @typing.overload
    def get_item_oapg(self, name: typing_extensions.Literal["not_author_name"]) -> typing.Union[MetaOapg.properties.not_author_name, schemas.Unset]: ...
    
    @typing.overload
    def get_item_oapg(self, name: typing_extensions.Literal["sources"]) -> typing.Union[MetaOapg.properties.sources, schemas.Unset]: ...
    
    @typing.overload
    def get_item_oapg(self, name: typing_extensions.Literal["predefined_sources"]) -> typing.Union[MetaOapg.properties.predefined_sources, schemas.Unset]: ...
    
    @typing.overload
    def get_item_oapg(self, name: typing_extensions.Literal["not_sources"]) -> typing.Union[MetaOapg.properties.not_sources, schemas.Unset]: ...
    
    @typing.overload
    def get_item_oapg(self, name: typing_extensions.Literal["lang"]) -> typing.Union[MetaOapg.properties.lang, schemas.Unset]: ...
    
    @typing.overload
    def get_item_oapg(self, name: typing_extensions.Literal["not_lang"]) -> typing.Union[MetaOapg.properties.not_lang, schemas.Unset]: ...
    
    @typing.overload
    def get_item_oapg(self, name: typing_extensions.Literal["countries"]) -> typing.Union[MetaOapg.properties.countries, schemas.Unset]: ...
    
    @typing.overload
    def get_item_oapg(self, name: typing_extensions.Literal["not_countries"]) -> typing.Union[MetaOapg.properties.not_countries, schemas.Unset]: ...
    
    @typing.overload
    def get_item_oapg(self, name: typing_extensions.Literal["from_"]) -> typing.Union[MetaOapg.properties.from_, schemas.Unset]: ...
    
    @typing.overload
    def get_item_oapg(self, name: typing_extensions.Literal["to_"]) -> typing.Union[MetaOapg.properties.to_, schemas.Unset]: ...
    
    @typing.overload
    def get_item_oapg(self, name: typing_extensions.Literal["published_date_precision"]) -> typing.Union[MetaOapg.properties.published_date_precision, schemas.Unset]: ...
    
    @typing.overload
    def get_item_oapg(self, name: typing_extensions.Literal["by_parse_date"]) -> typing.Union[MetaOapg.properties.by_parse_date, schemas.Unset]: ...
    
    @typing.overload
    def get_item_oapg(self, name: typing_extensions.Literal["sort_by"]) -> typing.Union[MetaOapg.properties.sort_by, schemas.Unset]: ...
    
    @typing.overload
    def get_item_oapg(self, name: typing_extensions.Literal["ranked_only"]) -> typing.Union[MetaOapg.properties.ranked_only, schemas.Unset]: ...
    
    @typing.overload
    def get_item_oapg(self, name: typing_extensions.Literal["from_rank"]) -> typing.Union[MetaOapg.properties.from_rank, schemas.Unset]: ...
    
    @typing.overload
    def get_item_oapg(self, name: typing_extensions.Literal["to_rank"]) -> typing.Union[MetaOapg.properties.to_rank, schemas.Unset]: ...
    
    @typing.overload
    def get_item_oapg(self, name: typing_extensions.Literal["is_headline"]) -> typing.Union[MetaOapg.properties.is_headline, schemas.Unset]: ...
    
    @typing.overload
    def get_item_oapg(self, name: typing_extensions.Literal["is_paid_content"]) -> typing.Union[MetaOapg.properties.is_paid_content, schemas.Unset]: ...
    
    @typing.overload
    def get_item_oapg(self, name: typing_extensions.Literal["parent_url"]) -> typing.Union[MetaOapg.properties.parent_url, schemas.Unset]: ...
    
    @typing.overload
    def get_item_oapg(self, name: typing_extensions.Literal["all_links"]) -> typing.Union[MetaOapg.properties.all_links, schemas.Unset]: ...
    
    @typing.overload
    def get_item_oapg(self, name: typing_extensions.Literal["all_domain_links"]) -> typing.Union[MetaOapg.properties.all_domain_links, schemas.Unset]: ...
    
    @typing.overload
    def get_item_oapg(self, name: typing_extensions.Literal["word_count_min"]) -> typing.Union[MetaOapg.properties.word_count_min, schemas.Unset]: ...
    
    @typing.overload
    def get_item_oapg(self, name: typing_extensions.Literal["word_count_max"]) -> typing.Union[MetaOapg.properties.word_count_max, schemas.Unset]: ...
    
    @typing.overload
    def get_item_oapg(self, name: typing_extensions.Literal["page"]) -> typing.Union[MetaOapg.properties.page, schemas.Unset]: ...
    
    @typing.overload
    def get_item_oapg(self, name: typing_extensions.Literal["page_size"]) -> typing.Union[MetaOapg.properties.page_size, schemas.Unset]: ...
    
    @typing.overload
    def get_item_oapg(self, name: typing_extensions.Literal["include_nlp_data"]) -> typing.Union[MetaOapg.properties.include_nlp_data, schemas.Unset]: ...
    
    @typing.overload
    def get_item_oapg(self, name: typing_extensions.Literal["has_nlp"]) -> typing.Union[MetaOapg.properties.has_nlp, schemas.Unset]: ...
    
    @typing.overload
    def get_item_oapg(self, name: typing_extensions.Literal["theme"]) -> typing.Union[MetaOapg.properties.theme, schemas.Unset]: ...
    
    @typing.overload
    def get_item_oapg(self, name: typing_extensions.Literal["not_theme"]) -> typing.Union[MetaOapg.properties.not_theme, schemas.Unset]: ...
    
    @typing.overload
    def get_item_oapg(self, name: typing_extensions.Literal["ner_name"]) -> typing.Union[MetaOapg.properties.ner_name, schemas.Unset]: ...
    
    @typing.overload
    def get_item_oapg(self, name: typing_extensions.Literal["title_sentiment_min"]) -> typing.Union[MetaOapg.properties.title_sentiment_min, schemas.Unset]: ...
    
    @typing.overload
    def get_item_oapg(self, name: typing_extensions.Literal["title_sentiment_max"]) -> typing.Union[MetaOapg.properties.title_sentiment_max, schemas.Unset]: ...
    
    @typing.overload
    def get_item_oapg(self, name: typing_extensions.Literal["content_sentiment_min"]) -> typing.Union[MetaOapg.properties.content_sentiment_min, schemas.Unset]: ...
    
    @typing.overload
    def get_item_oapg(self, name: typing_extensions.Literal["content_sentiment_max"]) -> typing.Union[MetaOapg.properties.content_sentiment_max, schemas.Unset]: ...
    
    @typing.overload
    def get_item_oapg(self, name: typing_extensions.Literal["iptc_tags"]) -> typing.Union[MetaOapg.properties.iptc_tags, schemas.Unset]: ...
    
    @typing.overload
    def get_item_oapg(self, name: typing_extensions.Literal["not_iptc_tags"]) -> typing.Union[MetaOapg.properties.not_iptc_tags, schemas.Unset]: ...
    
    @typing.overload
    def get_item_oapg(self, name: str) -> typing.Union[schemas.UnsetAnyTypeSchema, schemas.Unset]: ...
    
    def get_item_oapg(self, name: typing.Union[typing_extensions.Literal["author_name", "not_author_name", "sources", "predefined_sources", "not_sources", "lang", "not_lang", "countries", "not_countries", "from_", "to_", "published_date_precision", "by_parse_date", "sort_by", "ranked_only", "from_rank", "to_rank", "is_headline", "is_paid_content", "parent_url", "all_links", "all_domain_links", "word_count_min", "word_count_max", "page", "page_size", "include_nlp_data", "has_nlp", "theme", "not_theme", "ner_name", "title_sentiment_min", "title_sentiment_max", "content_sentiment_min", "content_sentiment_max", "iptc_tags", "not_iptc_tags", ], str]):
        return super().get_item_oapg(name)
    

    def __new__(
        cls,
        *args: typing.Union[dict, frozendict.frozendict, ],
        author_name: typing.Union[MetaOapg.properties.author_name, str, ],
        not_author_name: typing.Union[MetaOapg.properties.not_author_name, str, schemas.Unset] = schemas.unset,
        sources: typing.Union[MetaOapg.properties.sources, dict, frozendict.frozendict, str, date, datetime, uuid.UUID, int, float, decimal.Decimal, bool, None, list, tuple, bytes, io.FileIO, io.BufferedReader, schemas.Unset] = schemas.unset,
        predefined_sources: typing.Union[MetaOapg.properties.predefined_sources, dict, frozendict.frozendict, str, date, datetime, uuid.UUID, int, float, decimal.Decimal, bool, None, list, tuple, bytes, io.FileIO, io.BufferedReader, schemas.Unset] = schemas.unset,
        not_sources: typing.Union[MetaOapg.properties.not_sources, dict, frozendict.frozendict, str, date, datetime, uuid.UUID, int, float, decimal.Decimal, bool, None, list, tuple, bytes, io.FileIO, io.BufferedReader, schemas.Unset] = schemas.unset,
        lang: typing.Union[MetaOapg.properties.lang, dict, frozendict.frozendict, str, date, datetime, uuid.UUID, int, float, decimal.Decimal, bool, None, list, tuple, bytes, io.FileIO, io.BufferedReader, schemas.Unset] = schemas.unset,
        not_lang: typing.Union[MetaOapg.properties.not_lang, dict, frozendict.frozendict, str, date, datetime, uuid.UUID, int, float, decimal.Decimal, bool, None, list, tuple, bytes, io.FileIO, io.BufferedReader, schemas.Unset] = schemas.unset,
        countries: typing.Union[MetaOapg.properties.countries, dict, frozendict.frozendict, str, date, datetime, uuid.UUID, int, float, decimal.Decimal, bool, None, list, tuple, bytes, io.FileIO, io.BufferedReader, schemas.Unset] = schemas.unset,
        not_countries: typing.Union[MetaOapg.properties.not_countries, dict, frozendict.frozendict, str, date, datetime, uuid.UUID, int, float, decimal.Decimal, bool, None, list, tuple, bytes, io.FileIO, io.BufferedReader, schemas.Unset] = schemas.unset,
        from_: typing.Union[MetaOapg.properties.from_, dict, frozendict.frozendict, str, date, datetime, uuid.UUID, int, float, decimal.Decimal, bool, None, list, tuple, bytes, io.FileIO, io.BufferedReader, schemas.Unset] = schemas.unset,
        to_: typing.Union[MetaOapg.properties.to_, dict, frozendict.frozendict, str, date, datetime, uuid.UUID, int, float, decimal.Decimal, bool, None, list, tuple, bytes, io.FileIO, io.BufferedReader, schemas.Unset] = schemas.unset,
        published_date_precision: typing.Union[MetaOapg.properties.published_date_precision, str, schemas.Unset] = schemas.unset,
        by_parse_date: typing.Union[MetaOapg.properties.by_parse_date, bool, schemas.Unset] = schemas.unset,
        sort_by: typing.Union[MetaOapg.properties.sort_by, str, schemas.Unset] = schemas.unset,
        ranked_only: typing.Union[MetaOapg.properties.ranked_only, str, schemas.Unset] = schemas.unset,
        from_rank: typing.Union[MetaOapg.properties.from_rank, decimal.Decimal, int, schemas.Unset] = schemas.unset,
        to_rank: typing.Union[MetaOapg.properties.to_rank, decimal.Decimal, int, schemas.Unset] = schemas.unset,
        is_headline: typing.Union[MetaOapg.properties.is_headline, bool, schemas.Unset] = schemas.unset,
        is_paid_content: typing.Union[MetaOapg.properties.is_paid_content, bool, schemas.Unset] = schemas.unset,
        parent_url: typing.Union[MetaOapg.properties.parent_url, dict, frozendict.frozendict, str, date, datetime, uuid.UUID, int, float, decimal.Decimal, bool, None, list, tuple, bytes, io.FileIO, io.BufferedReader, schemas.Unset] = schemas.unset,
        all_links: typing.Union[MetaOapg.properties.all_links, dict, frozendict.frozendict, str, date, datetime, uuid.UUID, int, float, decimal.Decimal, bool, None, list, tuple, bytes, io.FileIO, io.BufferedReader, schemas.Unset] = schemas.unset,
        all_domain_links: typing.Union[MetaOapg.properties.all_domain_links, dict, frozendict.frozendict, str, date, datetime, uuid.UUID, int, float, decimal.Decimal, bool, None, list, tuple, bytes, io.FileIO, io.BufferedReader, schemas.Unset] = schemas.unset,
        word_count_min: typing.Union[MetaOapg.properties.word_count_min, decimal.Decimal, int, schemas.Unset] = schemas.unset,
        word_count_max: typing.Union[MetaOapg.properties.word_count_max, decimal.Decimal, int, schemas.Unset] = schemas.unset,
        page: typing.Union[MetaOapg.properties.page, decimal.Decimal, int, schemas.Unset] = schemas.unset,
        page_size: typing.Union[MetaOapg.properties.page_size, decimal.Decimal, int, schemas.Unset] = schemas.unset,
        include_nlp_data: typing.Union[MetaOapg.properties.include_nlp_data, bool, schemas.Unset] = schemas.unset,
        has_nlp: typing.Union[MetaOapg.properties.has_nlp, bool, schemas.Unset] = schemas.unset,
        theme: typing.Union[MetaOapg.properties.theme, str, schemas.Unset] = schemas.unset,
        not_theme: typing.Union[MetaOapg.properties.not_theme, str, schemas.Unset] = schemas.unset,
        ner_name: typing.Union[MetaOapg.properties.ner_name, str, schemas.Unset] = schemas.unset,
        title_sentiment_min: typing.Union[MetaOapg.properties.title_sentiment_min, decimal.Decimal, int, float, schemas.Unset] = schemas.unset,
        title_sentiment_max: typing.Union[MetaOapg.properties.title_sentiment_max, decimal.Decimal, int, float, schemas.Unset] = schemas.unset,
        content_sentiment_min: typing.Union[MetaOapg.properties.content_sentiment_min, decimal.Decimal, int, float, schemas.Unset] = schemas.unset,
        content_sentiment_max: typing.Union[MetaOapg.properties.content_sentiment_max, decimal.Decimal, int, float, schemas.Unset] = schemas.unset,
        iptc_tags: typing.Union[MetaOapg.properties.iptc_tags, dict, frozendict.frozendict, str, date, datetime, uuid.UUID, int, float, decimal.Decimal, bool, None, list, tuple, bytes, io.FileIO, io.BufferedReader, schemas.Unset] = schemas.unset,
        not_iptc_tags: typing.Union[MetaOapg.properties.not_iptc_tags, dict, frozendict.frozendict, str, date, datetime, uuid.UUID, int, float, decimal.Decimal, bool, None, list, tuple, bytes, io.FileIO, io.BufferedReader, schemas.Unset] = schemas.unset,
        _configuration: typing.Optional[schemas.Configuration] = None,
        **kwargs: typing.Union[schemas.AnyTypeSchema, dict, frozendict.frozendict, str, date, datetime, uuid.UUID, int, float, decimal.Decimal, None, list, tuple, bytes],
    ) -> 'AuthorSearchRequest':
        return super().__new__(
            cls,
            *args,
            author_name=author_name,
            not_author_name=not_author_name,
            sources=sources,
            predefined_sources=predefined_sources,
            not_sources=not_sources,
            lang=lang,
            not_lang=not_lang,
            countries=countries,
            not_countries=not_countries,
            from_=from_,
            to_=to_,
            published_date_precision=published_date_precision,
            by_parse_date=by_parse_date,
            sort_by=sort_by,
            ranked_only=ranked_only,
            from_rank=from_rank,
            to_rank=to_rank,
            is_headline=is_headline,
            is_paid_content=is_paid_content,
            parent_url=parent_url,
            all_links=all_links,
            all_domain_links=all_domain_links,
            word_count_min=word_count_min,
            word_count_max=word_count_max,
            page=page,
            page_size=page_size,
            include_nlp_data=include_nlp_data,
            has_nlp=has_nlp,
            theme=theme,
            not_theme=not_theme,
            ner_name=ner_name,
            title_sentiment_min=title_sentiment_min,
            title_sentiment_max=title_sentiment_max,
            content_sentiment_min=content_sentiment_min,
            content_sentiment_max=content_sentiment_max,
            iptc_tags=iptc_tags,
            not_iptc_tags=not_iptc_tags,
            _configuration=_configuration,
            **kwargs,
        )
