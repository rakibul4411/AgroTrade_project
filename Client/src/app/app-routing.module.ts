import { AuthGuard } from './auth/auth.guard';
import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { UserComponent } from './admin/user/user.component';
//import { RegistrationComponent } from './admin/user/registration/registration.component';
import { LoginComponent } from './admin/user/login/login.component';
import { HomeComponent } from './admin/home/home.component';
import { FarmersComponent } from './admin/farmers/farmers.component';

import { ProductcategoriesComponent } from './admin/productcategories/productcategories.component';
import { ProductcategoryComponent } from './admin/productcategories/productcategory/productcategory.component';
import { ProductcategoryListComponent } from './admin/productcategories/productcategory-list/productcategory-list.component';
import { ProductunitsComponent } from './admin/productunits/productunits.component';
import { UsersUiComponent } from './users-ui/users-ui.component';
import { AboutComponent } from './users-ui/about/about.component';
import { ProductsComponent } from './admin/products/products.component';
import { MarketsComponent } from './admin/markets/markets.component';
import { TradercategoriesComponent } from './admin/tradercategories/tradercategories.component';
import { MarketComponent } from './admin/markets/market/market.component';
import { RegistrationComponent } from './admin/user/registrations/registration/registration.component';
import { RegistrationsComponent } from './admin/user/registrations/registrations.component';
import { WholesalerComponent } from './admin/wholesalers/wholesaler/wholesaler.component';
import { WholesalersComponent } from './admin/wholesalers/wholesalers.component';
import { RetailersdetailsComponent } from './admin/retailersdetails/retailersdetails.component';
import { LocaltradersdetailsComponent } from './admin/localtradersdetails/localtradersdetails.component';
import { TraderslistsComponent } from './admin/traderslists/traderslists.component';
import { ImportedproductsourcesComponent } from './admin/importedproductsources/importedproductsources.component';
import { LocalproductsourcesComponent } from './admin/localproductsources/localproductsources.component';
import { LocaltraderorderdetailsComponent } from './admin/localtraderorderdetails/localtraderorderdetails.component';
import { RetailerorderdetailsComponent } from './admin/retailerorderdetails/retailerorderdetails.component';
import { WholesalerorderdetailsComponent } from './admin/wholesalerorderdetails/wholesalerorderdetails.component';

const routes: Routes = [
  {path:'',redirectTo:'home',pathMatch:'full'},
  {path:'home',component:HomeComponent},
  {
    path: 'user', component: UserComponent,
    children: [
      { path: 'registration', component: RegistrationComponent },
      { path: 'login', component: LoginComponent },
      { path: 'home', component: HomeComponent }
    ]
  },  
  {path:'farmers', component: FarmersComponent},
  {path:'products', component: ProductsComponent},
  {path:'productcategories', component: ProductcategoriesComponent},
  {path:'productunit', component: ProductunitsComponent},
  {path:'markets', component: MarketsComponent},
  {path:'tradercategories', component: TradercategoriesComponent},
  {path:'wholesalers', component: WholesalersComponent},
  {path:'retailersdetails', component: RetailersdetailsComponent},
  {path:'localtradersdetails', component: LocaltradersdetailsComponent},
  {path:'traderslists', component: TraderslistsComponent},
  {path:'importedproductsources', component: ImportedproductsourcesComponent},
  {path:'localproductsources', component: LocalproductsourcesComponent},
  {path:'localtraderorderdetails', component: LocaltraderorderdetailsComponent},
  {path:'retailerorderdetails', component: RetailerorderdetailsComponent},
  {path:'wholesalerorderdetails', component: WholesalerorderdetailsComponent},
 
  
  {path:'registrations', component: RegistrationsComponent},

  {path:'users-ui', component:UsersUiComponent},
  {path:'about', component:AboutComponent},
  
  {path:'**',redirectTo:'home',pathMatch:'full'}
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
