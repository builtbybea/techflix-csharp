﻿﻿import React, {FunctionComponent} from "react";
import styles from "./Biography.module.scss";

interface ParagraphProps {
    title: string
    paragraph: string;
}

interface BiographyProps {
    biography: string;
}

interface OverviewProps {
    overview: string;
}

const ParagraphSection: FunctionComponent<ParagraphProps> = ({title, paragraph}) => {
    return (
        <section className={styles.section}>
            <h2 className={styles.title}>{title}</h2>
            <p className={styles.biography}>{paragraph}</p>
        </section>
    );
};

export const Biography: FunctionComponent<BiographyProps> = ({biography}) => {
    return <ParagraphSection title="Biography" paragraph={biography}/>;    
};

export const Overview: FunctionComponent<OverviewProps> = ({overview}) => {
    return <ParagraphSection title="Overview" paragraph={overview}/>
};
