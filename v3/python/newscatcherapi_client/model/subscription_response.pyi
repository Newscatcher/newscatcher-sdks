# coding: utf-8

"""
    NewsCatcher-V3 Production API

    <img src='https://uploads-ssl.webflow.com/6429857b17973b636c2195c5/646c6f1eb774ff2f2997bec5_newscatcher_.svg' width='286' height='35' /> <br>  <br>Visit our website  <a href='https://newscatcherapi.com'>https://newscatcherapi.com</a> <br> <p style=\"color: red\"><b><em> This is a Testing Phase API. Please use it for testing purposes only. </em></b></p> <br>

    The version of the OpenAPI document: Beta-3.0.0
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


class SubscriptionResponse(
    schemas.DictSchema
):
    """
    This class is auto generated by Konfig (https://konfigthis.com)
    """


    class MetaOapg:
        required = {
            "active",
            "plan_name",
        }
        
        class properties:
            active = schemas.BoolSchema
            plan_name = schemas.StrSchema
            calls_per_seconds = schemas.IntSchema
            usage_assigned_calls = schemas.IntSchema
            usage_remaining_calls = schemas.IntSchema
            historical_days = schemas.IntSchema
            __annotations__ = {
                "active": active,
                "plan_name": plan_name,
                "calls_per_seconds": calls_per_seconds,
                "usage_assigned_calls": usage_assigned_calls,
                "usage_remaining_calls": usage_remaining_calls,
                "historical_days": historical_days,
            }
    
    active: MetaOapg.properties.active
    plan_name: MetaOapg.properties.plan_name
    
    @typing.overload
    def __getitem__(self, name: typing_extensions.Literal["active"]) -> MetaOapg.properties.active: ...
    
    @typing.overload
    def __getitem__(self, name: typing_extensions.Literal["plan_name"]) -> MetaOapg.properties.plan_name: ...
    
    @typing.overload
    def __getitem__(self, name: typing_extensions.Literal["calls_per_seconds"]) -> MetaOapg.properties.calls_per_seconds: ...
    
    @typing.overload
    def __getitem__(self, name: typing_extensions.Literal["usage_assigned_calls"]) -> MetaOapg.properties.usage_assigned_calls: ...
    
    @typing.overload
    def __getitem__(self, name: typing_extensions.Literal["usage_remaining_calls"]) -> MetaOapg.properties.usage_remaining_calls: ...
    
    @typing.overload
    def __getitem__(self, name: typing_extensions.Literal["historical_days"]) -> MetaOapg.properties.historical_days: ...
    
    @typing.overload
    def __getitem__(self, name: str) -> schemas.UnsetAnyTypeSchema: ...
    
    def __getitem__(self, name: typing.Union[typing_extensions.Literal["active", "plan_name", "calls_per_seconds", "usage_assigned_calls", "usage_remaining_calls", "historical_days", ], str]):
        # dict_instance[name] accessor
        return super().__getitem__(name)
    
    
    @typing.overload
    def get_item_oapg(self, name: typing_extensions.Literal["active"]) -> MetaOapg.properties.active: ...
    
    @typing.overload
    def get_item_oapg(self, name: typing_extensions.Literal["plan_name"]) -> MetaOapg.properties.plan_name: ...
    
    @typing.overload
    def get_item_oapg(self, name: typing_extensions.Literal["calls_per_seconds"]) -> typing.Union[MetaOapg.properties.calls_per_seconds, schemas.Unset]: ...
    
    @typing.overload
    def get_item_oapg(self, name: typing_extensions.Literal["usage_assigned_calls"]) -> typing.Union[MetaOapg.properties.usage_assigned_calls, schemas.Unset]: ...
    
    @typing.overload
    def get_item_oapg(self, name: typing_extensions.Literal["usage_remaining_calls"]) -> typing.Union[MetaOapg.properties.usage_remaining_calls, schemas.Unset]: ...
    
    @typing.overload
    def get_item_oapg(self, name: typing_extensions.Literal["historical_days"]) -> typing.Union[MetaOapg.properties.historical_days, schemas.Unset]: ...
    
    @typing.overload
    def get_item_oapg(self, name: str) -> typing.Union[schemas.UnsetAnyTypeSchema, schemas.Unset]: ...
    
    def get_item_oapg(self, name: typing.Union[typing_extensions.Literal["active", "plan_name", "calls_per_seconds", "usage_assigned_calls", "usage_remaining_calls", "historical_days", ], str]):
        return super().get_item_oapg(name)
    

    def __new__(
        cls,
        *args: typing.Union[dict, frozendict.frozendict, ],
        active: typing.Union[MetaOapg.properties.active, bool, ],
        plan_name: typing.Union[MetaOapg.properties.plan_name, str, ],
        calls_per_seconds: typing.Union[MetaOapg.properties.calls_per_seconds, decimal.Decimal, int, schemas.Unset] = schemas.unset,
        usage_assigned_calls: typing.Union[MetaOapg.properties.usage_assigned_calls, decimal.Decimal, int, schemas.Unset] = schemas.unset,
        usage_remaining_calls: typing.Union[MetaOapg.properties.usage_remaining_calls, decimal.Decimal, int, schemas.Unset] = schemas.unset,
        historical_days: typing.Union[MetaOapg.properties.historical_days, decimal.Decimal, int, schemas.Unset] = schemas.unset,
        _configuration: typing.Optional[schemas.Configuration] = None,
        **kwargs: typing.Union[schemas.AnyTypeSchema, dict, frozendict.frozendict, str, date, datetime, uuid.UUID, int, float, decimal.Decimal, None, list, tuple, bytes],
    ) -> 'SubscriptionResponse':
        return super().__new__(
            cls,
            *args,
            active=active,
            plan_name=plan_name,
            calls_per_seconds=calls_per_seconds,
            usage_assigned_calls=usage_assigned_calls,
            usage_remaining_calls=usage_remaining_calls,
            historical_days=historical_days,
            _configuration=_configuration,
            **kwargs,
        )
