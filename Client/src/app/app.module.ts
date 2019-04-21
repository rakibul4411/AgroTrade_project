import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
//import { FormsModule } from "@angular/forms";
//import { HttpClientModule } from '@angular/common/http';
import { ReactiveFormsModule, FormsModule } from "@angular/forms";
import { HttpClientModule, HTTP_INTERCEPTORS } from "@angular/common/http";
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { ToastrModule } from 'ngx-toastr';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';


import { UsersUiComponent } from './users-ui/users-ui.component';
import { UserComponent } from './admin/user/user.component';
import { RegistrationComponent } from './admin/user/registrations/registration/registration.component';
import { UserService } from './shared/user.service';
import { LoginComponent } from './admin/user/login/login.component';
import { HomeComponent } from './admin/home/home.component';
import { AuthInterceptor } from './auth/auth.interceptor';
import { FarmersComponent } from './admin/farmers/farmers.component';
import { FarmerComponent } from './admin/farmers/farmer/farmer.component';
import { FarmerListComponent } from './admin/farmers/farmer-list/farmer-list.component';
import { FarmerService } from './shared/farmer.service';
import { ProductcategoriesComponent } from './admin/productcategories/productcategories.component';
import { ProductcategoryComponent } from './admin/productcategories/productcategory/productcategory.component';
import { ProductcategoryListComponent } from './admin/productcategories/productcategory-list/productcategory-list.component';
import { ProductcategoryService } from './shared/productcategory.service';
import { ProductunitsComponent } from './admin/productunits/productunits.component';
import { ProductunitComponent } from './admin/productunits/productunit/productunit.component';
import { ProductunitListComponent } from './admin/productunits/productunit-list/productunit-list.component';
import { ProductunitService } from './shared/productunit.service';
import { AboutComponent } from './users-ui/about/about.component';
import { ProductsComponent } from './admin/products/products.component';
import { MarketsComponent } from './admin/markets/markets.component';
import { MarketComponent } from './admin/markets/market/market.component';
import { MarketListComponent } from './admin/markets/market-list/market-list.component';
import { TradercategoriesComponent } from './admin/tradercategories/tradercategories.component';
import { TradercategoryComponent } from './admin/tradercategories/tradercategory/tradercategory.component';
import { TradercategoryListComponent } from './admin/tradercategories/tradercategory-list/tradercategory-list.component';
import { TradercategoryService } from './shared/tradercategory.service';
import { MarketService } from './shared/market.service';
import { RegistrationsComponent } from './admin/user/registrations/registrations.component';
import { RegistrationListComponent } from './admin/user/registrations/registration-list/registration-list.component';
import { WholesalersComponent } from './admin/wholesalers/wholesalers.component';
import { WholesalerComponent } from './admin/wholesalers/wholesaler/wholesaler.component';
import { WholesalerListComponent } from './admin/wholesalers/wholesaler-list/wholesaler-list.component';
import { RetailersdetailsComponent } from './admin/retailersdetails/retailersdetails.component';
import { RetailersdetailComponent } from './admin/retailersdetails/retailersdetail/retailersdetail.component';
import { RetailersdetailListComponent } from './admin/retailersdetails/retailersdetail-list/retailersdetail-list.component';
import { LocaltradersdetailsComponent } from './admin/localtradersdetails/localtradersdetails.component';
import { LocaltradersdetailComponent } from './admin/localtradersdetails/localtradersdetail/localtradersdetail.component';
import { LocaltradersdetailListComponent } from './admin/localtradersdetails/localtradersdetail-list/localtradersdetail-list.component';
import { WholesalerService } from './shared/wholesaler.service';
import { RetailersdetailService } from './shared/retailersdetail.service';
import { TraderslistsComponent } from './admin/traderslists/traderslists.component';
import { TraderslistComponent } from './admin/traderslists/traderslist/traderslist.component';
import { TraderslistListComponent } from './admin/traderslists/traderslist-list/traderslist-list.component';
import { ProductComponent } from './admin/products/product/product.component';
import { ProductListComponent } from './admin/products/product-list/product-list.component';
import { ImportedproductsourcesComponent } from './admin/importedproductsources/importedproductsources.component';
import { ImportedproductsourceComponent } from './admin/importedproductsources/importedproductsource/importedproductsource.component';
import { ImportedproductsourceListComponent } from './admin/importedproductsources/importedproductsource-list/importedproductsource-list.component';
import { LocalproductsourcesComponent } from './admin/localproductsources/localproductsources.component';
import { LocalproductsourceComponent } from './admin/localproductsources/localproductsource/localproductsource.component';
import { LocalproductsourceListComponent } from './admin/localproductsources/localproductsource-list/localproductsource-list.component';
import { LocaltraderorderdetailsComponent } from './admin/localtraderorderdetails/localtraderorderdetails.component';
import { LocaltraderorderdetailComponent } from './admin/localtraderorderdetails/localtraderorderdetail/localtraderorderdetail.component';
import { LocaltraderorderdetailListComponent } from './admin/localtraderorderdetails/localtraderorderdetail-list/localtraderorderdetail-list.component';
import { RetailerorderdetailsComponent } from './admin/retailerorderdetails/retailerorderdetails.component';
import { RetailerorderdetailComponent } from './admin/retailerorderdetails/retailerorderdetail/retailerorderdetail.component';
import { RetailerorderdetailListComponent } from './admin/retailerorderdetails/retailerorderdetail-list/retailerorderdetail-list.component';
import { WholesalerorderdetailsComponent } from './admin/wholesalerorderdetails/wholesalerorderdetails.component';
import { WholesalerorderdetailComponent } from './admin/wholesalerorderdetails/wholesalerorderdetail/wholesalerorderdetail.component';
import { WholesalerorderdetailListComponent } from './admin/wholesalerorderdetails/wholesalerorderdetail-list/wholesalerorderdetail-list.component';
import { LocalproductsourceService } from './shared/localproductsource.service';
import { ProductService } from './shared/product.service';
import { TraderslistService } from './shared/traderslist.service';
import { LocaltradersdetailService } from './shared/localtradersdetail.service';

@NgModule({
  declarations: [
    AppComponent,
    UserComponent,
    RegistrationComponent,
    LoginComponent,
    HomeComponent,
    FarmersComponent,
    FarmerComponent,
    FarmerListComponent,
    ProductcategoriesComponent,
    ProductcategoryComponent,
    ProductcategoryListComponent,
    ProductunitsComponent,
    ProductunitComponent,
    ProductunitListComponent,
    UsersUiComponent,
    AboutComponent,
    ProductsComponent,
    MarketsComponent,
    MarketComponent,
    MarketListComponent,
    TradercategoriesComponent,
    TradercategoryComponent,
    TradercategoryListComponent,
    RegistrationsComponent,
    RegistrationListComponent,
    WholesalersComponent,
    WholesalerComponent,
    WholesalerListComponent,
    RetailersdetailsComponent,
    RetailersdetailComponent,
    RetailersdetailListComponent,
    LocaltradersdetailsComponent,
    LocaltradersdetailComponent,
    LocaltradersdetailListComponent,
    TraderslistsComponent,
    TraderslistComponent,
    TraderslistListComponent,
    ProductComponent,
    ProductListComponent,
    ImportedproductsourcesComponent,
    ImportedproductsourceComponent,
    ImportedproductsourceListComponent,
    LocalproductsourcesComponent,
    LocalproductsourceComponent,
    LocalproductsourceListComponent,
    LocaltraderorderdetailsComponent,
    LocaltraderorderdetailComponent,
    LocaltraderorderdetailListComponent,
    RetailerorderdetailsComponent,
    RetailerorderdetailComponent,
    RetailerorderdetailListComponent,
    WholesalerorderdetailsComponent,
    WholesalerorderdetailComponent,
    WholesalerorderdetailListComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    ReactiveFormsModule,
    HttpClientModule,
    BrowserAnimationsModule,
    ToastrModule.forRoot({
      progressBar: true
    }),
    FormsModule
  ],
  providers: [UserService,FarmerService,ProductcategoryService,
              ProductunitService, TradercategoryService,MarketService,
               WholesalerService, RetailersdetailService, LocalproductsourceService,
               ProductService, TraderslistService,LocaltradersdetailService,  {
    provide: HTTP_INTERCEPTORS,
    useClass: AuthInterceptor,
    multi: true
  }],
  bootstrap: [AppComponent]
})
export class AppModule { }
