import { Routes } from '@angular/router';
import { HomeComponent } from './home/home.component';
import { StockpileListComponent } from './stockpile-list/stockpile-list.component';
import { BrandsComponent } from './brands/brands.component';
import { PlatformsComponent } from './platforms/platforms.component';
import { AuthGuard } from './_guards/auth.guard';

export const appRoutes: Routes = [
    {path: '', component: HomeComponent},
    {
        path: '',
        runGuardsAndResolvers: 'always',
        canActivate: [AuthGuard],
        children: [
            {path: 'stockpile', component: StockpileListComponent},
            {path: 'brands', component: BrandsComponent},
            {path: 'platforms', component: PlatformsComponent},
        ]
    },
    {path: '**', redirectTo: '', pathMatch: 'full'},
];
