"use strict";
var __decorate = (this && this.__decorate) || function (decorators, target, key, desc) {
    var c = arguments.length, r = c < 3 ? target : desc === null ? desc = Object.getOwnPropertyDescriptor(target, key) : desc, d;
    if (typeof Reflect === "object" && typeof Reflect.decorate === "function") r = Reflect.decorate(decorators, target, key, desc);
    else for (var i = decorators.length - 1; i >= 0; i--) if (d = decorators[i]) r = (c < 3 ? d(r) : c > 3 ? d(target, key, r) : d(target, key)) || r;
    return c > 3 && r && Object.defineProperty(target, key, r), r;
};
var __metadata = (this && this.__metadata) || function (k, v) {
    if (typeof Reflect === "object" && typeof Reflect.metadata === "function") return Reflect.metadata(k, v);
};
Object.defineProperty(exports, "__esModule", { value: true });
var core_1 = require("@angular/core"); //
var http_1 = require("@angular/common/http");
var rxjs_1 = require("rxjs"); //
var SellerComponent = /** @class */ (function () {
    function SellerComponent(http) {
        this.http = http;
        this.dtOptions = {}; //
        this.dtTrigger = new rxjs_1.Subject(); //
        this.title = 'Altuntaş';
        this.sellers = [];
    }
    SellerComponent.prototype.ngOnInit = function () {
        var _this = this;
        this.dtOptions = {
            pagingType: 'full_numbers',
            pageLength: 2,
            language: {
                "url": "//cdn.datatables.net/plug-ins/1.10.13/i18n/Turkish.json"
            }
        };
        this.http.get("https://localhost:44315/api/sellers").subscribe(function (data) {
            _this.sellers = data;
            _this.dtTrigger.next(); //
        });
    };
    SellerComponent.prototype.ngOnDestroy = function () {
        // Do not forget to unsubscribe the event
        this.dtTrigger.unsubscribe();
    };
    SellerComponent = __decorate([
        core_1.Component({
            selector: 'seller',
            templateUrl: './seller.component.html',
            styleUrls: ['./seller.component.css']
        }),
        __metadata("design:paramtypes", [http_1.HttpClient])
    ], SellerComponent);
    return SellerComponent;
}());
exports.SellerComponent = SellerComponent;
//# sourceMappingURL=seller.component.js.map